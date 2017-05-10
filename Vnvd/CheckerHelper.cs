
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using Vnvd.Antlr;
using Vnvd.UserDefined;

namespace Vnvd
{
   /// <summary>
   /// This is the helper class for the Checker TreeWalker part of Vnvd.
   /// </summary>
   public class CheckerHelper : AbstractHelper
   {
      List<String> searchPath = new List<String>();
      private String currentNamespace;
      private UserType currentType;
      private IMethodOrConstructor currentMethod;

      private LibraryChecker lib;
      private NumberFormatInfo numberformat;

      /// <summary>
      /// Constructs a CheckerHelper instance.
      /// </summary>
      public CheckerHelper()
      {
         lib = Vnvd.Library;

         numberformat = new NumberFormatInfo();
         numberformat.NumberDecimalSeparator = ".";
      }

      public VnvdTreeWalker Walker
      {
         get; set;
      }

      public TreeNode ReplaceNode(TreeNode node, int token, String text)
      {
         TreeNode repl = (TreeNode)Walker.TreeAdaptor.Create(token, text);

         Walker.TreeAdaptor.SetChild(node.Parent, node.ChildIndex, repl);
         foreach (TreeNode chd in node.Children)
         {
            Walker.TreeAdaptor.AddChild(repl, chd);
         }
         return repl;
      }

      public override void Program(TreeNode node)
      {
         
      }

      public override void Import(TreeNode node, Qualifier qualifier)
      {
         this.searchPath.Add(qualifier.ToString());
      }

      public override void Interface(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> extendation)
      {
      }

      public override void Namespace(TreeNode node, Qualifier qualifier)
      {
         this.searchPath.Remove(qualifier.ToString());
      }

      public override void BeginClass(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> extendation, List<Qualifier> implementation)
      {
         currentType = (UserType)node.Entry.ReflectionObject;
      }

      public override void BeginInterface(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> extendation)
      {
         currentType = (UserType)node.Entry.ReflectionObject;
      }

      public override void InterfaceMethod(TreeNode node, Qualifier qualifier, string identifier, List<Parameter> parameters)
      {
      }

      public override void Class(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> extendation, List<Qualifier> implementation)
      {
      }

      public override void ConstField(TreeNode node, List<string> modifiers, Qualifier qualifier, string identifier)
      {
      }

      public override void Constructor(TreeNode node, List<string> modifiers, List<Parameter> parameters)
      {
         currentMethod.SymbolTable.CloseScope();
      }

      public override void Field(TreeNode node, List<string> modifiers, Qualifier qualifier, string identifier)
      {
      }

      public override void BeginMethod(TreeNode node, List<string> modifiers, Qualifier qualifier, string identifier, List<Parameter> parameters)
      {
         currentMethod = (IMethodOrConstructor)node.Entry.ReflectionObject;
      }

      public override void BeginConstructor(TreeNode node, List<string> modifiers, List<Parameter> parameters, TreeNode bas)
      {
         if (bas != null)
         {
            bas.Entry = new IdEntry();
            TreeNode treeArgs = (TreeNode)bas.GetChild(0);
            Type[] args = new Type[treeArgs.ChildCount];
            for (int i = 0; i < treeArgs.ChildCount; i++)
            {
               args[i] = ((TreeNode)treeArgs.GetChild(i).GetChild(0)).ReturnType;
            }

            Type baseType = currentType.BaseType;
            IdEntry entry = this.GetConstructorIdEntry(baseType, args);
            ConstructorInfo cons = entry != null ? (ConstructorInfo)entry.ReflectionObject : null;
            if (cons == null)
               throw new CheckerException(node, "No constructor can be found for " + currentType.BaseType.FullName);
            if (cons.IsPrivate)
               throw new CheckerException(node, "Constructor for " + currentType.BaseType.FullName + " is not accessible");

            bas.Entry = entry;
         }
         else
         {
            IdEntry entry = this.GetConstructorIdEntry(currentType.BaseType, Type.EmptyTypes);
            if (entry == null)
               throw new CheckerException(node, "No suitable base constructor found to call");
            ConstructorInfo cons = (ConstructorInfo)entry.ReflectionObject;
            if (cons == null)
               throw new CheckerException(node, "No parameterless constructor can be found for " + currentType.BaseType.FullName);
            if (cons.IsPrivate)
               throw new CheckerException(node, "Constructor for " + currentType.BaseType.FullName + " is not accessible");
            TreeNode child = (TreeNode)node.GetChild(1);
            child.Entry = entry;

         }
      }

      public override void BeginConstructorBeforeBaseCall(TreeNode node)
      {
         currentMethod = (IMethodOrConstructor)node.Entry.ReflectionObject;
      }

      public override void WhileLoop(TreeNode node)
      {
         TreeNode entrySelf = ((TreeNode)(node.GetChild(0)));
         TreeNode entry1 = ((TreeNode)(node.GetChild(1)));

         if (entrySelf.ReturnType != typeof(Boolean))
         {
            throw new CheckerException(node, "System.Boolean expected here, got: " + entrySelf.ReturnType.FullName);
         }

         node.ReturnType = typeof(void);
      }

      public override void DeclarationStatement(TreeNode node, Qualifier qualifier, string identifier)
      {
         IdEntry entry = new IdEntry();
         IdEntry t = this.GetTypeIdEntry(qualifier.ToString());
         if (t == null)
         {
            throw new CheckerException(node, "Type " + qualifier + " cannot be found");
         }
         entry.ReflectionObject = currentMethod.DefineLocal(t, identifier);
         node.EntryType = EntryType.Variable;
         entry.Node = node;
         node.ReturnType = typeof(void);
         try
         {
            currentMethod.SymbolTable.Enter(identifier, entry);
         }
         catch (SymbolTableException ex)
         {
            throw new CheckerException(node, ex.Message);
         }

         node.Entry = entry;
      }

      public override void ObjectCreation(TreeNode node, Qualifier qualifier)
      {
         Type t = lib.GetType(qualifier.ToString(), searchPath);
         // check other assemblies

         if (t == null)
            throw new CheckerException(node, "Type cannot be found " + qualifier.ToString());
         if (t.IsAbstract)
            throw new CheckerException(node, "Abstract type " + t.FullName + " cannot be instantiated");

         TreeNode args = (TreeNode)node.GetChild(1);
         Type[] types = new Type[args.ChildCount];

         for (int i = 0; i < args.ChildCount; i++)
         {
            types[i] = ((TreeNode)(args.GetChild(i).GetChild(0))).ReturnType;
         }

         if (t.IsSubclassOf(typeof(MulticastDelegate)) && types.Length == 1 && types[0] is MethodType)
         {
            types = new Type[] { typeof(object), typeof(IntPtr) };
         }

         IdEntry entry = GetConstructorIdEntry(t, types);
         ConstructorInfo cons = entry != null ? (ConstructorInfo)entry.ReflectionObject : null;
         if (cons == null)
         {
            throw new CheckerException(node, "Constructor of type " + t.FullName + " is not defined");
         }

         if (!IsAccessible(cons, currentType.FullName.Equals(t.FullName), false, false))
            throw new CheckerException(node, "Constructor of type " + t.FullName + " is not accessible");

         node.Entry = entry;
         node.ReturnType = t;
      }

      /// <summary>
      /// Returns whether something is accessible.
      /// </summary>
      /// <param name="modifiers">The modifiers used on the item</param>
      /// <param name="inclass">Whether the used item is declared in the same class</param>
      /// <param name="inparent">Whether the used item is declared in a parent class</param>
      /// <param name="inassembly">Whether the used item is declared in the same assembly</param>
      /// <returns>Whether the item is accessible</returns>
      private bool IsAccessible(ICollection<string> modifiers, bool inclass, bool inparent, bool inassembly)
      {
         if (inclass)
            return true;
         if (inparent)
            return modifiers.Contains("public") || modifiers.Contains("internal") || modifiers.Contains("protected");
         if (inassembly)
            return modifiers.Contains("public") || modifiers.Contains("internal");

         return modifiers.Contains("public");
      }

      /// <summary>
      /// Returns whether a method is accessible.
      /// </summary>
      /// <param name="info">The method</param>
      /// <param name="inclass">Whether the method is declared in the same class</param>
      /// <param name="inparent">Whether the method is declared in a parent class</param>
      /// <param name="inassembly">Whether the method is declared in the same assembly</param>
      /// <returns>Whether the method is accessible</returns>
      private bool IsAccessible(MethodBase info, bool inclass, bool inparent, bool inassembly)
      {
         if (inclass)
            return true;
         if (inparent && inassembly)
            return info.IsPublic || info.IsFamily || info.IsFamilyAndAssembly || info.IsFamilyOrAssembly;
         if (inparent)
            return info.IsPublic || info.IsFamily || info.IsFamilyOrAssembly;
         if (inassembly)
            return info.IsPublic || info.IsAssembly || info.IsFamilyOrAssembly;

         return info.IsPublic;
      }

      /// <summary>
      /// Returns whether a field is accessible.
      /// </summary>
      /// <param name="info">The field</param>
      /// <param name="inclass">Whether the field is declared in the same class</param>
      /// <param name="inparent">Whether the field is declared in a parent class</param>
      /// <param name="inassembly">Whether the field is declared in the same assembly</param>
      /// <returns>Whether the field is accessible</returns>
      private bool IsAccessible(FieldInfo info, bool inclass, bool inparent, bool inassembly)
      {
         if (inclass)
            return true;
         if (inparent && inassembly)
            return info.IsPublic || info.IsFamily || info.IsFamilyAndAssembly || info.IsFamilyOrAssembly;
         if (inparent)
            return info.IsPublic || info.IsFamily || info.IsFamilyOrAssembly;
         if (inassembly)
            return info.IsPublic || info.IsAssembly || info.IsFamilyOrAssembly;

         return info.IsPublic;
      }

      private bool IsToBeCalled(TreeNode node)
      {
         return ((node.Parent.Type != VnvdTreeWalker.BECOMES && node.Parent.Type != VnvdTreeWalker.ADDEVENT &&
                  node.Parent.Type != VnvdTreeWalker.REMEVENT) || node.ChildIndex == node.Parent.ChildCount - 1);
      }

      public override void InvocationExpr(TreeNode node, string identifier)
      {
         TreeNode child = (TreeNode)node.GetChild(0);
         Type t = child.ReturnType ?? (Type)child.Entry.ReflectionObject;
         bool isstatic = child.ReturnType == null ? true : false;
         bool inclass = currentType.FullName.Equals(t.FullName);
         bool inparent = currentType.IsSubclassOf(t);
         IdEntry id;

         if (child.EntryType == EntryType.Constant && child.Entry.Node.GetChild(0).GetChild(child.Entry.Node.GetChild(0).ChildCount - 1).Type == VnvdTreeWalker.ARRAY)
         {
            throw new CheckerException(node, "Calling method on a constant array");
         }
         
         if (node.ChildCount > 2)
         {
            TreeNode args = (TreeNode)node.GetChild(2);
            Type[] types = new Type[args.ChildCount];

            for (int i = 0; i < args.ChildCount; i++)
            {
               types[i] = ((TreeNode)(args.GetChild(i).GetChild(0))).ReturnType;
            }

            id = GetMethodIdEntry(t, identifier, types);
            MethodInfo m = id != null ? (MethodInfo)id.ReflectionObject : null;

            String methodName = (t.Namespace != String.Empty ? t.Namespace + "." : String.Empty) + t.Name + "." + identifier + "(";
            for (int i = 0; i < types.Length; i++)
            {
               methodName += (types[i].Namespace != String.Empty ? types[i].Namespace + "." : String.Empty) + types[i].Name;

               if (i < types.Length - 1)
               {
                  methodName += ", ";
               }
            }
            methodName += ")";

            if (m != null)
            {
               if (isstatic && !m.IsStatic)
                  throw new CheckerException(node, "Calling non-static method (" + methodName + ")  from static context");
               if (!isstatic && m.IsStatic)
                  throw new CheckerException(node, "Accessing static method (" + methodName + ")  from nonstatic context");
               if (!IsAccessible(m, inclass, inparent, false))
                  throw new CheckerException(node, "Method " + methodName + " not accessible");

               if (IsToBeCalled(node))
               {
                  if (m.IsVirtual && !m.DeclaringType.IsValueType && node.GetChild(0).Type != VnvdTreeWalker.BASE)
                     node = ReplaceNode(node, VnvdTreeWalker.CALLVIRT, "CALLVIRT");
                  else
                     node = ReplaceNode(node, VnvdTreeWalker.CALL, "CALL");
               }
               else
               {
                  node = ReplaceNode(node, VnvdTreeWalker.DONTLD, "DONTLD");
               }

               node.Entry = id;
               node.ReturnType = m.ReturnType;
               node.EntryType = EntryType.Method;

            }
            else
            {
               throw new CheckerException(node, "Method unknown: " + methodName + " on " + t.FullName);
            }
         }
         else
         {
            MethodInfo m;
            if ((id = GetFieldIdEntry(t, identifier)) != null)
            {
               FieldInfo f = (FieldInfo)id.ReflectionObject;
               if (isstatic && !f.IsStatic)
                  throw new CheckerException(node, "Accessing non-static field (" + f.Name + ") from static context");
               if (!isstatic && f.IsStatic)
                  throw new CheckerException(node, "Accessing static field (" + f.Name + ") from nonstatic context");
               if (!IsAccessible(f, inclass, inparent, false))
                  throw new CheckerException(node, "Field " + f.Name + " not accessible");

               if (IsToBeCalled(node))
               {
                  if (f.IsLiteral)
                     node = ReplaceNode(node, VnvdTreeWalker.LDLITERAL, "LDLITERAL");
                  else if (f.IsStatic)
                     node = ReplaceNode(node, VnvdTreeWalker.LDSFLD, "LDSFLD");
                  else
                     node = ReplaceNode(node, VnvdTreeWalker.LDFLD, "LDFLD");
               }
               else
               {
                  node = ReplaceNode(node, VnvdTreeWalker.DONTLD, "DONTLD");
               }

               if (f.IsLiteral)
               {
                  node.Value = (f is UserField) ? ((UserField) f).ConstantValue : f.GetRawConstantValue();
               }

               node.Entry = id;
               node.ReturnType = f.FieldType;
               node.EntryType = EntryType.Field;
            }
            else if ((id = GetEventIdEntry(t, identifier)) != null)
            {
               EventInfo f = (EventInfo)id.ReflectionObject;
               m = f.GetAddMethod();
               if (!isstatic && m.IsStatic)
                  throw new CheckerException(node, "Accessing static field (" + f.Name + ") from nonstatic context");
               if (isstatic && !m.IsStatic)
                  throw new CheckerException(node, "Accessing an event (" + f.Name + ") from static context");
               if (!IsAccessible(m, inclass, inparent, false))
                  throw new CheckerException(node, "Event " + f.Name + " not accessible");

               if (IsToBeCalled(node))
               {
                  // to be implemented when events are added
               }
               else
               {
                  node = ReplaceNode(node, VnvdTreeWalker.DONTLD, "DONTLD");
               }

               node.Entry = id;
               node.ReturnType = f.EventHandlerType;
               node.EntryType = EntryType.Event;
            }
            else
            {
               TreeNode p = (TreeNode)node.Parent.Parent.Parent;
               if (p.Type != VnvdTreeWalker.NEW)
               {
                  throw new CheckerException(node, "Unknown field: " + identifier + " on " + t.FullName);
               }
               else
               {
                  Qualifier q = GetFullQualifier(p.GetChild(0));
                  IdEntry entry = this.GetTypeIdEntry(q.ToString());
                  if (entry == null)
                     throw new CheckerException(p, "Type not found " + q.ToString());

                  Type type = (Type)entry.ReflectionObject;
                  MethodInfo mInvoke = type.GetMethod("Invoke");

                  if (mInvoke == null)
                  {
                     throw new CheckerException(p, "Unknown field: " + identifier + " on " + t.FullName);
                  }
                  ParameterInfo[] pars = mInvoke.GetParameters();
                  
                  Type[] mPars = new Type[pars.Length];
                  for (int i = 0; i < pars.Length; i++)
                  {
                     mPars[i] = pars[i].ParameterType;
                  }

                  entry = this.GetMethodIdEntry(t, identifier, mPars);
                  if (entry == null)
                  {
                     throw new CheckerException(node, "Method or field not found " + identifier + " on " + t.FullName);
                  }
                  m = (MethodInfo)entry.ReflectionObject;

                  if (IsToBeCalled(node))
                  {
                     if (m.IsVirtual && !m.IsFinal)
                        node = ReplaceNode(node, VnvdTreeWalker.LDVIRTFTN, "LDVIRTFTN");
                     else
                        node = ReplaceNode(node, VnvdTreeWalker.LDFTN, "LDFTN");
                  }
                  else
                  {
                     node = ReplaceNode(node, VnvdTreeWalker.DONTLD, "DONTLD");
                  }

                  if (!isstatic && m.IsStatic)
                     throw new CheckerException(node, "Accessing static method (" + m.Name + ") from nonstatic context");
                  if (isstatic && !m.IsStatic)
                     throw new CheckerException(node, "Accessing a method (" + m.Name + ") from static context");
                  if (!IsAccessible(m, inclass, inparent, false))
                     throw new CheckerException(node, "Method " + m.Name + " is not accessible");

                  node.Entry = entry;
                  node.ReturnType = MethodType.GetMethodType(m);
               }
            }
         }
      }

      public override void BeforeArrayElementedCreationExpr(TreeNode node)
      {
      }

      public override void BeforeArrayElementedElement(TreeNode node)
      {
      }

      public override void ArrayElementedElement(TreeNode node)
      {
         node.ReturnType = ((TreeNode) node.GetChild(0)).ReturnType;
      }

      public override void ArrayElementedCreationExpr(TreeNode node)
      {
         IdEntry q = this.GetTypeIdEntry(this.FullQualifier(node.GetChild(0)).ToString());

         if (q != null)
         {
            Type arrayType = ((Type)q.ReflectionObject);
            IdEntry el = GetTypeIdEntry(arrayType.GetElementType().FullName);
            
            if (!arrayType.IsArray)
            {
               throw new CheckerException(node, "Array initialization expression must be an array type");
            }

            TreeNode child = (TreeNode)node.GetChild(1);
            for (int i = 0; i < child.ChildCount; i++)
            {
               TreeNode element = (TreeNode)child.GetChild(i);
               element.Entry = el;

               if (!IsAssignableFrom((Type)el.ReflectionObject, element.ReturnType))
               {
                  throw new CheckerException(element, "Array element is of a different type");
               }
            }

            node.ReturnType = arrayType;
            node.Entry = el;
         }
         else
         {
            throw new CheckerException(node, "Type array initialization not found ");
         }
      }

      public override void AssignmentExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node, true);
         TreeNode child2 = (TreeNode)node.GetChild(0);
         if (child2.EntryType == EntryType.Method || child2.EntryType == EntryType.Event || child2.EntryType == EntryType.Constant)
         {
            TreeNode child = (TreeNode)node.GetChild(0).GetChild(0);
            throw new CheckerException(node, "Left part of assignment is not assignable: " + (child.ReturnType != null ? child.ReturnType.FullName + "::" + node.GetChild(0).GetChild(1).Text : String.Empty));
         }
         else if(child2.EntryType == EntryType.Field)
         {
            FieldInfo f = (FieldInfo)child2.Entry.ReflectionObject;
            if ((f.IsInitOnly && (currentMethod.MemberType != MemberTypes.Constructor || currentMethod.IsStatic != f.IsStatic)) || f.IsLiteral)
            {
               throw new CheckerException(node, "A value cannot be assigned to the constant or initonly variable: " + f.Name);
            }
         }
         node.Entry = child2.Entry;
      }

      public override void TernaryExpr(TreeNode node)
      {
         TreeNode entrySelf = ((TreeNode)(node.GetChild(0)));
         TreeNode entry1 = ((TreeNode)(node.GetChild(1)));
         TreeNode entry2 = ((TreeNode)(node.GetChild(2)));

         if (entrySelf.ReturnType != typeof(bool))
         {
            throw new CheckerException(node, "System.Boolean expected here, got: " + entrySelf.ReturnType.FullName);
         }

         if (entry2 == null || !entry1.ReturnType.FullName.Equals(entry2.ReturnType.FullName))
         {
            // then and else types don't match, or else part is missing so return type is void
            node.ReturnType = typeof(void);
         }
         else
         {
            // return type is type of then and else part
            node.ReturnType = entry1.ReturnType;
         }
      }

      public override void Method(TreeNode node, List<string> modifiers, Qualifier qualifier, string identifier, List<Parameter> parameters)
      {
         TreeNode entry1 = ((TreeNode)(node.GetChild(4)));
         MethodInfo m = ((MethodInfo) node.Entry.ReflectionObject);
         Type ret = m.ReturnType;

         if (!m.IsAbstract && ret != typeof(void) && (ret.IsValueType || entry1.ReturnType != NullType.Default) && !IsAssignableFrom(entry1.ReturnType, ret))
         {
            throw new CheckerException(node, "Method return type does not match: got: " + entry1.ReturnType.FullName + ", expected: " + ret.FullName);
         }

         currentMethod.SymbolTable.CloseScope();
      }

      public override void EndConditionalOrExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         if (node.ReturnType != typeof(Boolean))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the || operator");
         }
      }

      public override void EndConditionalAndExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         if (node.ReturnType != typeof(Boolean))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the && operator");
         }
      }

      public override void LessExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         node.ReturnType = typeof(Boolean);
         if (!CheckBinaryOperatorOverload(node, "op_LessThan", node.ReturnType))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the < operator");
         }
      }

      public override void LessEqualExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         node.ReturnType = typeof(Boolean);
         if (!CheckBinaryOperatorOverload(node, "op_LessThanOrEqual", node.ReturnType))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the <= operator");
         }
      }

      public override void GreaterExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         node.ReturnType = typeof(Boolean);
         if (!CheckBinaryOperatorOverload(node, "op_GreaterThan", node.ReturnType))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the > operator");
         }
      }

      public override void GreaterEqualExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         node.ReturnType = typeof(Boolean);
         if (!CheckBinaryOperatorOverload(node, "op_GreaterThanOrEqual", node.ReturnType))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the >= operator");
         }
      }

      public override void EqualExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         CheckBinaryOperatorOverload(node, "op_Equality", node.ReturnType);
         node.ReturnType = typeof(Boolean);
      }

      public override void NotEqualExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         CheckBinaryOperatorOverload(node, "op_Inequality", node.ReturnType);
         node.ReturnType = typeof(Boolean);
      }

      public override void PlusExpr(TreeNode node)
      {
         TreeNode child = (TreeNode)node.GetChild(0);
         this.CheckTwoSidedNode(node);
         if (!CheckBinaryOperatorOverload(node, "op_Addition", child.ReturnType))
         {
            if (child.ReturnType == typeof(string))
            {
               node.Entry = new IdEntry();
               node.Entry.ReflectionObject = typeof(String).GetMethod("Concat",
                                                                       new Type[] { typeof(object), typeof(object) });
               node.ReturnType = child.ReturnType;
            }
            else
            {
               throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the + operator");
            }
         }
      }

      public override void MinusExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         if (!CheckBinaryOperatorOverload(node, "op_Subtraction", node.ReturnType))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the - operator");
         }
      }

      public override void MultiplyExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         if (!CheckBinaryOperatorOverload(node, "op_Multiply", node.ReturnType))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the * operator");
         }
      }

      public override void DivisionExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         if (!CheckBinaryOperatorOverload(node, "op_Division", node.ReturnType))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the / operator");
         }
      }

      public override void ModExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         if (!CheckBinaryOperatorOverload(node, "op_Modulus", node.ReturnType))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the % operator");
         }
      }

      public override void LogicNotExpr(TreeNode node)
      {
         TreeNode child = (TreeNode)node.GetChild(0);
         if (!CheckUnaryOperatorOverload(node, "op_LogicalNot", child.ReturnType))
         {
            throw new CheckerException(node, "Type " + child.ReturnType + " is not compatible with the ! operator");
         }
      }

      /// <summary>
      /// Checks the usage of a binary operator.
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="operator_">The operator used</param>
      /// <param name="t">The type used on the operator</param>
      /// <returns>Whether the usage is correct</returns>
      public bool CheckBinaryOperatorOverload(TreeNode node, String operator_, Type t)
      {
         if (t.IsPrimitive)
         {
            node.Entry = new IdEntry();
            node.ReturnType = t;
            return true;
         }
         else if ((node.Entry = this.GetMethodIdEntry(t, operator_, new Type[] { t, t })) != null)
         {
            node.ReturnType = ((MethodInfo)node.Entry.ReflectionObject).ReturnType;
            return true;
         }
         else
         {
            node.Entry = new IdEntry();
            return false;
         }
      }

      /// <summary>
      /// Checks the usage of an unary operator.
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="operator_">The operator used</param>
      /// <param name="t">The type used on the operator</param>
      /// <returns>Whether the usage is correct</returns>
      public bool CheckUnaryOperatorOverload(TreeNode node, String operator_, Type t)
      {
         if (t.IsPrimitive)
         {
            node.Entry = new IdEntry();
            node.ReturnType = t;
            return true;
         }
         else if ((node.Entry = this.GetMethodIdEntry(t, operator_, new Type[] { t })) != null)
         {
            node.ReturnType = ((MethodInfo)node.Entry.ReflectionObject).ReturnType;
            return true;
         }
         else
         {
            return false;
         }
      }

      /// <summary>
      /// Checks a two sided node.
      /// This checks whether the types on both sides of a node are the same or have the same parent type.
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="isAssignment">Whether it is an assignment node</param>
      public void CheckTwoSidedNode(TreeNode node, bool isAssignment)
      {
         TreeNode node1 = ((TreeNode)(node.GetChild(0)));
         TreeNode node2 = ((TreeNode)(node.GetChild(1)));

         if (node2.ReturnType != null && (isAssignment ? (!IsAssignableFrom(node1.ReturnType, node2.ReturnType) && node2.ReturnType != NullType.Default) : (node1.ReturnType != node2.ReturnType && node1.ReturnType != NullType.Default && node2.ReturnType != NullType.Default))
            )
         {
            throw new CheckerException(node, "Types do not match: " + node1.ReturnType.FullName + " and " + node2.ReturnType.FullName);
         }

         node.ReturnType = node2.ReturnType != NullType.Default ? node2.ReturnType : node1.ReturnType;
      }

      /// <summary>
      /// Checks a two sided node.
      /// This is an overload for a non-assignment node.
      /// </summary>
      /// <param name="node">The AST node</param>
      public void CheckTwoSidedNode(TreeNode node)
      {
         this.CheckTwoSidedNode(node, false);
      }

      public override void VariableUsed(TreeNode node, Qualifier qual)
      {
         IdEntry entry;
         if (qual.Count == 1 && (entry = currentMethod.SymbolTable.Retrieve(qual[0])) != null)
         {
            node.Entry = entry;
            node.ReturnType = entry.ReflectionObject is UserLocal
                                 ? ((UserLocal)entry.ReflectionObject).LocalType
                                 : ((UserParameter)entry.ReflectionObject).ParameterType;

            if (entry.Node != null && entry.Node.EntryType == EntryType.Constant)
            {
               node.Value = entry.Node.Value;
               node.EntryType = EntryType.Constant;
            }
         }
         else
         {
            node.Entry = this.GetTypeIdEntry(qual.ToString());
            if (node.Entry == null)
            {
               throw new CheckerException(node, "Type " + qual + " cannot be found");
            }
         }
      }

      public override void LiteralNull(TreeNode node)
      {
         node.ReturnType = NullType.Default;
         node.Value = DBNull.Value;
      }

      public override void LiteralNumber(TreeNode node)
      {
         node.ReturnType = typeof(Int32);
         node.Value = Int32.Parse(node.Text);
      }

      public override void LiteralFloat(TreeNode node)
      {
         node.ReturnType = typeof(double);
         node.Value = Double.Parse(node.Text, numberformat);
      }

      public override void LiteralString(TreeNode node)
      {
         node.ReturnType = typeof(String);

         try
         {
            node.Value = StringHelper.StringFromCSharpLiteral(node.Text.Substring(1, node.Text.Length - 2));
         }
         catch (ArgumentException e)
         {
            throw new CheckerException(node, e.Message);
         }
      }

      public override void LiteralCharacter(TreeNode node)
      {
         node.ReturnType = typeof(Char);

         try
         {
            node.Value = StringHelper.CharFromCSharpLiteral(node.Text.Substring(1, node.Text.Length - 2));
         }
         catch (ArgumentException e)
         {
            throw new CheckerException(node, e.Message);
         }
      }

      public override void LiteralBoolean(TreeNode node)
      {
         node.ReturnType = typeof(Boolean);
         node.Value = Boolean.Parse(node.Text);
      }

      public override void ExpressionBlock(TreeNode node)
      {
         TreeNode expr = (TreeNode)node.GetChild(0);
         node.ReturnType = expr.ReturnType;
      }

      public override void StatementBlock(TreeNode node)
      {
         if (node.ChildCount > 0)
         {
            TreeNode child = ((TreeNode) (node.GetChild(node.ChildCount - 1)));
            node.ReturnType = child.ReturnType;
            if (child.Type == VnvdTreeWalker.LOCAL || child.Type == VnvdTreeWalker.CONST)
            {
               throw new CheckerException((TreeNode)node.GetChild(node.ChildCount - 1), "A compound expression must not end with a declaration.");
            }
         }
         else
         {
            node.ReturnType = typeof(void);
         }
      }

      public override void BeginProgram(TreeNode node)
      {
      }

      public override void OpenScope()
      {
         currentMethod.SymbolTable.OpenScope();
      }

      public override void CloseScope()
      {
         currentMethod.SymbolTable.CloseScope();
      }

      public override void BeginNamespace(TreeNode node, Qualifier qual)
      {
         this.searchPath.Add(qual.ToString());
         currentNamespace = node.Text;
      }

      public override void ScopeExpr(TreeNode node)
      {
         node.ReturnType = ((TreeNode)node.GetChild(node.ChildCount - 1)).ReturnType;
      }

      public override void LiteralThis(TreeNode node)
      {
         node.Entry = currentType.Entry;
         node.ReturnType = currentType;

         if (currentMethod.IsStatic)
         {
            throw new CheckerException(node, "Cannot reference to this in a static context");
         }
      }

      public override void LiteralBase(TreeNode node)
      {
         node.Entry = currentType.Entry;
         node.ReturnType = currentType.BaseType;

         if (currentMethod.IsStatic)
         {
            throw new CheckerException(node, "Cannot reference to base in a static context");
         }
         if (node.Parent.Type != VnvdTreeWalker.DCOLON || ((TreeNode)node.Parent).EntryType == EntryType.Method)
         {
            throw new CheckerException(node, "The keyword base cannot be used in this context");
         }
      }

      public override void CastExpression(TreeNode node, Qualifier qual)
      {
         node.Entry = GetTypeIdEntry(qual.ToString());
         if (node.Entry == null)
         {
            throw new CheckerException(node, "Type " + qual + " cannot be found");
         }
         node.ReturnType = (Type)node.Entry.ReflectionObject;

         TreeNode child = (TreeNode)node.GetChild(1);
         if (!IsAssignableFrom(child.ReturnType, node.ReturnType) && !IsAssignableFrom(node.ReturnType, child.ReturnType) && !(child.ReturnType.IsPrimitive && node.ReturnType.IsPrimitive))
            throw new CheckerException(node, "Unable to cast " + child.ReturnType.FullName + " to " + qual.ToString());
      }

      public override void CastAsExpression(TreeNode node, Qualifier qual)
      {
         node.Entry = GetTypeIdEntry(qual.ToString());
         if (node.Entry == null)
         {
            throw new CheckerException(node, "Type " + qual + " cannot be found");
         }
         node.ReturnType = (Type)node.Entry.ReflectionObject;

         TreeNode child = (TreeNode)node.GetChild(0);
         if (!IsAssignableFrom(child.ReturnType, node.ReturnType) && !IsAssignableFrom(node.ReturnType, child.ReturnType))
            throw new CheckerException(node, "Unable to cast " + child.ReturnType.FullName + " to " + qual.ToString());
      }

      public override void UnaryPlusExpr(TreeNode node)
      {
         TreeNode child = (TreeNode)node.GetChild(0);
         if (!CheckUnaryOperatorOverload(node, "op_UnaryPlus", child.ReturnType))
         {
            throw new CheckerException(node, "Type " + child.ReturnType + " is not compatible with the unary + operator");
         }
      }

      public override void UnaryMinusExpr(TreeNode node)
      {
         TreeNode child = (TreeNode)node.GetChild(0);
         if (!CheckUnaryOperatorOverload(node, "op_UnaryNegation", child.ReturnType))
         {
            throw new CheckerException(node, "Type " + child.ReturnType + " is not compatible with the unary - operator");
         }
      }

      public override void BeginTry(TreeNode node)
      {
      }

      public override void EndTry(TreeNode node)
      {
         node.ReturnType = typeof(void);
      }

      public override void BeginCatch(TreeNode node, TreeNode node2, Qualifier qual, string identifier)
      {
         Type exc = ((UserLocal)node2.Entry.ReflectionObject).LocalType;
         if (!IsAssignableFrom(typeof(Exception), exc))
         {
            throw new CheckerException(node, "Only types which extend System.Exception may be caught: " + exc.FullName);
         }
      }

      public override void EndCatch(TreeNode node, Qualifier qual, string identifier)
      {
         node.ReturnType = typeof(void);
      }

      public override void BeginFinally(TreeNode node)
      {
      }

      public override void EndFinally(TreeNode node)
      {
         node.ReturnType = typeof (void);
      }

      public override void ConstantDeclaration(TreeNode node, Qualifier qualifier, string identifier)
      {
         TreeNode literal = (TreeNode)node.GetChild(2);

         IdEntry entry = new IdEntry();
         IdEntry t = this.GetTypeIdEntry(qualifier.ToString());
         if (t == null)
         {
            throw new CheckerException(node, "Type " + qualifier + " cannot be found");
         }
         entry.ReflectionObject = currentMethod.DefineLocal(t, identifier);
         node.EntryType = EntryType.Constant;
         entry.Node = node;
         node.ReturnType = literal.ReturnType;
         node.Value = literal.Value;

         if (((UserLocal)entry.ReflectionObject).LocalType != node.ReturnType)
         {
            throw new CheckerException(node, "Constant literal is not of the declared type");
         }

         try
         {
            currentMethod.SymbolTable.Enter(identifier, entry);
         }
         catch (SymbolTableException ex)
         {
            throw new CheckerException(node, ex.Message);
         }

         node.Entry = entry;
      }

      public override void AccessArray(TreeNode node)
      {
         TreeNode child1 = (TreeNode)node.GetChild(0);
         TreeNode child2 = (TreeNode)node.GetChild(1);
         if (!child1.ReturnType.IsArray)
         {
            throw new CheckerException(node, "Accessing elements is only allowed on an array type");
         }
         if (child2.ReturnType != typeof(int))
         {
            throw new CheckerException(node, "Array accessing expression must be of type System.Int32");
         }

         node.ReturnType = child1.ReturnType.GetElementType();
         node.Entry = child1.Entry;

         if (child1.EntryType == EntryType.Constant)
         {
            node.EntryType = EntryType.Constant;

            if (child2.Value == null)
            {
               throw new CheckerException(node, "Array accessing expression on constant arrays must be a literal.");
            }

            int element = (int) child2.Value;
            int elementCount = child1.Entry.Node.GetChild(2).ChildCount;

            if (element >= elementCount)
            {
               throw new CheckerException(node, "Array index out of bounds on constant array.");
            }

            TreeNode valueElement = (TreeNode) child1.Entry.Node.GetChild(2).GetChild(element);

            node.Value = valueElement.Value;
            child2.Value = null;
         }
         else
         {
            node.EntryType = EntryType.Array;
         }

      }

      public override void ConstLiteralNumber(TreeNode node)
      {
         this.LiteralNumber(node);
      }

      public override void ConstLiteralFloat(TreeNode node)
      {
         this.LiteralFloat(node);
      }

      public override void ConstLiteralCharacter(TreeNode node)
      {
         this.LiteralCharacter(node);
      }

      public override void ConstLiteralBoolean(TreeNode node)
      {
         this.LiteralBoolean(node);
      }

      public override void ConstLiteralString(TreeNode node)
      {
         this.LiteralString(node);
      }

      public override void ArrayCreationExpr(TreeNode node)
      {
         IdEntry q = this.GetTypeIdEntry(this.FullQualifier(node.GetChild(0)).ToString());

         if (q != null)
         {
            TreeNode child = (TreeNode)node.GetChild(1);
            if (child.ReturnType == typeof(int))
            {
               node.ReturnType = ((Type)q.ReflectionObject).MakeArrayType();
               node.Entry = q;
            }
            else
            {
               throw new CheckerException(node, "Array initialization expression must be of type System.Int32");
            }
         }
         else
         {
            throw new CheckerException(node, "Type array initialization not found ");
         }
      }

      public override void ConstDecl(TreeNode node)
      {

      }

      public override void ThrowStatement(TreeNode node)
      {
         TreeNode node2 = (TreeNode)node.GetChild(0);
         if (!IsAssignableFrom(typeof(Exception), node2.ReturnType))
         {
            throw new CheckerException(node, "Only types which extend System.Exception may be thrown: " + node2.ReturnType.FullName);
         }

         node.ReturnType = typeof(void);
         node.Entry = node2.Entry;
      }

      /// <summary>
      /// Returns the IdEntry of a type.
      /// </summary>
      /// <param name="name">The name of the type</param>
      /// <returns>The IdEntry</returns>
      public IdEntry GetTypeIdEntry(String name)
      {
         Type t = lib.GetType(name);
         if (t != null)
         {
            if (t is UserType)
               return ((UserType)t).Entry;
            else
               return new IdEntry() { ReflectionObject = t };
         }

         foreach (String s in searchPath)
         {
            t = lib.GetType(s + "." + name);
            if (t != null)
            {
               if (t is UserType)
                  return ((UserType)t).Entry;
               else
                  return new IdEntry() { ReflectionObject = t };
            }
         }
         return null;
      }

      /// <summary>
      /// Returns the IdEntry of an event.
      /// </summary>
      /// <param name="searchType">The name of the type the event is in</param>
      /// <param name="searchEvent">The name of the event</param>
      /// <returns>The IdEntry</returns>
      public IdEntry GetEventIdEntry(Type searchType, String searchEvent)
      {
         EventInfo t = searchType.GetEvent(searchEvent, BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
         if (t != null)
         {
            //if (t is UserMethod)
            //   return ((UserMethod)t).Entry;
            //else
            return new IdEntry() { ReflectionObject = t };
         }
         return null;
      }

      /// <summary>
      /// Returns the IdEntry of a method.
      /// </summary>
      /// <param name="searchType">The name of the type the method is in</param>
      /// <param name="searchMethod">The name of the method</param>
      /// <param name="paramTypes">The types of the parameters</param>
      /// <returns>The IdEntry</returns>
      public IdEntry GetMethodIdEntry(Type searchType, String searchMethod, Type[] paramTypes)
      {
         if (ContainsErrorType(paramTypes))
            return null;

         MethodInfo t = searchType.GetMethod(searchMethod, BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, CustomBinder.Default, paramTypes, null);
         if (t != null)
         {
            if (t is UserMethod)
               return ((UserMethod)t).Entry;
            else
               return new IdEntry() { ReflectionObject = t };
         }
         return null;
      }

      /// <summary>
      /// Returns the IdEntry of a field.
      /// </summary>
      /// <param name="searchType">The name of the type the field is in</param>
      /// <param name="searchField">The name of the field</param>
      /// <returns>The IdEntry</returns>
      public IdEntry GetFieldIdEntry(Type searchType, String searchField)
      {
         FieldInfo t = searchType.GetField(searchField, BindingFlags.FlattenHierarchy | BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
         if (t != null)
         {
            if (t is UserField)
               return ((UserField)t).Entry;
            else
               return new IdEntry() { ReflectionObject = t };
         }
         return null;
      }

      /// <summary>
      /// Checks whether a list of types contains an error type.
      /// </summary>
      /// <param name="paramTypes">The list of types</param>
      /// <returns>Whether the list of types contains an error type</returns>
      private bool ContainsErrorType(Type[] paramTypes)
      {
         foreach (Type t in paramTypes)
         {
            if (t == ErrorType.Default)
               return true;
         }
         return false;
      }

      /// <summary>
      /// Returns the IdEntry of a constructor.
      /// </summary>
      /// <param name="searchType">The name of the type</param>
      /// <param name="paramTypes">The types of the parameters</param>
      /// <returns>The IdEntry</returns>
      public IdEntry GetConstructorIdEntry(Type searchType, Type[] paramTypes)
      {
         if (ContainsErrorType(paramTypes))
            return null;
         ConstructorInfo t = searchType.GetConstructor(BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, CustomBinder.Default, paramTypes, new ParameterModifier[] { });
         if (t != null)
         {
            if (t is UserConstructor)
               return ((UserConstructor)t).Entry;
            else
               return new IdEntry() { ReflectionObject = t };
         }
         return null;
      }

      public override void AbstractMethod(TreeNode node, List<string> list, Qualifier return_, string p, List<Parameter> list_5)
      {
      }

      public override void BeginFor(TreeNode node, TreeNode node2, Qualifier qual, string identifier)
      {
         Type inclause = ((TreeNode)node.GetChild(1)).ReturnType;
         if (!IsAssignableFrom(typeof(IEnumerable), inclause))
         {
            throw new CheckerException(node, "Expression used as in-clause is not enumerable: " + inclause.FullName);
         }
      }

      public override void ForLoop(TreeNode node)
      {
         node.ReturnType = typeof (void);
      }

      public override void ReadExpression(TreeNode node, String identifier)
      {
         IdEntry entry;
         if ((entry = currentMethod.SymbolTable.Retrieve(identifier)) != null)
         {
            node.Entry = entry;
            node.ReturnType = entry.ReflectionObject is UserLocal
                                 ? ((UserLocal)entry.ReflectionObject).LocalType
                                 : ((UserParameter)entry.ReflectionObject).ParameterType;
         }
         else
         {
            throw new CheckerException(node, "Only local variables can be used as argument of read()");
         }
      }

      public override void ReadVoidExpression(TreeNode node, String identifier)
      {
         IdEntry entry;
         if ((entry = currentMethod.SymbolTable.Retrieve(identifier)) != null)
         {
            node.Entry = entry;
         }
         else
         {
            node.Entry = this.GetTypeIdEntry(identifier);
            if (node.Entry == null)
            {
               throw new CheckerException(node, "Type " + identifier + " cannot be found");
            }
         }

         node.ReturnType = typeof(void);
      }

      public override void WriteExpression(TreeNode node)
      {
         TreeNode child = (TreeNode)node.Children[0];
         node.ReturnType = child.ReturnType;
      }

      public override void WriteVoidExpression(TreeNode node)
      {
         node.ReturnType = typeof(void);
      }

      public override void AddEventExpr(TreeNode node)
      {
         node.EntryType = ((TreeNode)node.GetChild(0)).EntryType;
         if (node.EntryType != EntryType.Event)
            throw new CheckerException(node, "Operator += can only be used on events");
         this.CheckTwoSidedNode(node, true);
         node.Entry = ((TreeNode) node.GetChild(0)).Entry;
      }

      public override void RemoveEventExpr(TreeNode node)
      {
         node.EntryType = ((TreeNode)node.GetChild(0)).EntryType;
         if (node.EntryType != EntryType.Event)
            throw new CheckerException(node, "Operator -= can only be used on events");
         this.CheckTwoSidedNode(node, true);
         node.Entry = ((TreeNode)node.GetChild(0)).Entry;
      }

      public override void LogicOrExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         if (!CheckBinaryOperatorOverload(node, "op_BitwiseOr", node.ReturnType) && !node.ReturnType.IsDefined(typeof(FlagsAttribute), true))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the | operator");
         }
      }

      public override void LogicXorExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         if (!CheckBinaryOperatorOverload(node, "op_ExclusiveOr", node.ReturnType) && !node.ReturnType.IsDefined(typeof(FlagsAttribute), true))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the ^ operator");
         }
      }

      public override void LogicAndExpr(TreeNode node)
      {
         this.CheckTwoSidedNode(node);
         if (!CheckBinaryOperatorOverload(node, "op_BitwiseAnd", node.ReturnType) && !node.ReturnType.IsDefined(typeof(FlagsAttribute), true))
         {
            throw new CheckerException(node, "Type " + node.ReturnType + " is not compatible with the & operator");
         }
      }

      public override void BeginCondOr(TreeNode node)
      {
      }

      public override void MiddleCondOr(TreeNode node)
      {
      }

      public override void BeginCondAnd(TreeNode node)
      {
      }

      public override void MiddleCondAnd(TreeNode node)
      {
      }

      public override void IsTypeExpression(TreeNode node, Qualifier qual)
      {
         node.Entry = GetTypeIdEntry(qual.ToString());
         if (node.Entry == null)
         {
            throw new CheckerException(node, "Type " + qual + " cannot be found");
         }
         node.ReturnType = typeof (bool);
      }

      public override void TernaryElse(TreeNode node)
      {
      }

      public override void TernaryThen(TreeNode node)
      {
      }

      public override void WhileStart(TreeNode node)
      {
      }

      public override void WhileAfterExpr(TreeNode node)
      {
      }

      public override void ConstantArray(TreeNode node)
      {
         node.ReturnType = ((TreeNode)node.GetChild(0)).ReturnType.MakeArrayType();

         for (int i = 1; i < node.ChildCount; i++)
         {
            TreeNode element = (TreeNode)node.GetChild(i);

            if (((TreeNode)node.GetChild(0)).ReturnType != element.ReturnType)
            {
               throw new CheckerException(element, "Constant array element is of a different type");
            }
         }
      }

      public override void ConstantArrayElement(TreeNode node)
      {
         node.ReturnType = ((TreeNode)node.GetChild(0)).ReturnType;
         node.Value = ((TreeNode) node.GetChild(0)).Value;
      }

      public override void BeginStaticConstructor(TreeNode node)
      {
         currentMethod = (IMethodOrConstructor)node.Entry.ReflectionObject;
      }

      public override void EndStaticConstructor(TreeNode node)
      {
      }

      public override void CallVirtual(TreeNode node, string text)
      {
         throw new NotImplementedException();
      }

      public override void Call(TreeNode node, string text)
      {
         throw new NotImplementedException();
      }

      public override void LoadField(TreeNode node, string text)
      {
         throw new NotImplementedException();
      }

      public override void LoadStaticField(TreeNode node, string text)
      {
         throw new NotImplementedException();
      }

      public override void LoadLiteral(TreeNode node, string text)
      {
         throw new NotImplementedException();
      }

      public override void LoadVirtualFunction(TreeNode node, string text)
      {
         throw new NotImplementedException();
      }

      public override void LoadFunction(TreeNode node, string text)
      {
         throw new NotImplementedException();
      }

      public override void FieldAssignment(TreeNode node, string text)
      {
         throw new NotImplementedException();
      }
   }

   /// <summary>
   /// This class represents a checker exception.
   /// </summary>
   public class CheckerException : Exception
   {
      private List<Pair<TreeNode, String>> errors;

      /// <summary>
      /// Constructs a checker exception.
      /// </summary>
      public CheckerException()
      {
         this.errors = new List<Pair<TreeNode, string>>();
      }

      /// <summary>
      /// Constructs a checker exception with a message.
      /// </summary>
      /// <param name="msg">The message</param>
      public CheckerException(String msg)
         : this(null, msg)
      {
      }

      /// <summary>
      /// Constructs a checker exception with a message on a specified node.
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="msg">The message</param>
      public CheckerException(TreeNode node, String msg)
         : base(msg)
      {
         this.errors = new List<Pair<TreeNode, string>>();
         AddError(node, msg);
      }

      /// <summary>
      /// Adds an error to the exception.
      /// </summary>
      /// <param name="node">The AST node</param>
      /// <param name="msg">The message</param>
      public void AddError(TreeNode node, String msg)
      {
         errors.Add(new Pair<TreeNode, string>(node, msg));
      }

      /// <summary>
      /// Sets the last error node.
      /// </summary>
      /// <param name="node">The AST node</param>
      public void SetLastError(TreeNode node)
      {
         this.errors[errors.Count - 1].First = node;
      }

      /// <summary>
      /// Returns the last error.
      /// </summary>
      /// <returns>The last error</returns>
      public Pair<TreeNode, String> GetLastError()
      {
         return errors.Count > 0 ? errors[errors.Count - 1] : null;
      }

      /// <summary>
      /// Returns the number of errors.
      /// </summary>
      public int ErrorCount { get { return errors.Count; } }

      public override string ToString()
      {
         StringBuilder sb = new StringBuilder();
         foreach (Pair<TreeNode, String> p in errors)
         {
            TreeNode node = p.First;
            if (node != null)
               sb.AppendLine(node.Line + ":" + node.CharPositionInLine + "\t" + p.Second);
            else
               sb.AppendLine(p.Second);
         }
         if (sb.Length > 0 && sb[sb.Length - 1] == '\n')
            sb.Remove(sb.Length - 1, 1);
         return sb.ToString();
      }
   }
}