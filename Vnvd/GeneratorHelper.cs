using System.Collections;
using Antlr.Runtime.Tree;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System;
using Vnvd.Antlr;
using Vnvd.UserDefined;

namespace Vnvd
{
   /// <summary>
   /// This class is the helper class for the Generator TreeWalker of Vnvd. It handles the functionality of the VnvdTreeWalker.
   /// </summary>
   public class GeneratorHelper : AbstractHelper
   {
      private ILGenerator ig;
      private MethodBuilder metb;
      private Type tb;
      private ConstructorBuilder cb;
      private ModuleBuilder mb;
      private List<TypeBuilder> allTypes;
      private Stack<Label> forStartLabels = new Stack<Label>(), forEndLabels = new Stack<Label>();
      private Stack<Label> whileStartLabels = new Stack<Label>(), whileEndLabels = new Stack<Label>();
      private Stack<Label> elseLabels = new Stack<Label>(), endLabels = new Stack<Label>();
      private Stack<Label> condAndLabelsTrue = new Stack<Label>(), condAndLabelsFalse = new Stack<Label>();
      private Stack<Label> condOrLabelsTrue = new Stack<Label>(), condOrLabelsFalse = new Stack<Label>();
      private Dictionary<Type, LocalBuilder> hiddenLocals = new Dictionary<Type, LocalBuilder>();

      private string currentNamespace = String.Empty;

      /// <summary>
      /// Creates a new instance of the GeneraterHelper class
      /// </summary>
      public GeneratorHelper()
      {
         allTypes = new List<TypeBuilder>();
         mb = Vnvd.ModBuilder;
      }

      public override void BeginNamespace(TreeNode node, Qualifier qualifier)
      {
         currentNamespace = qualifier.ToString();
      }

      public override void Program(TreeNode node)
      {
      }

      public override void Import(TreeNode node, Qualifier qualifier)
      {
      }

      public override void Namespace(TreeNode node, Qualifier qualifier)
      {

      }

      public override void Class(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> extendation, List<Qualifier> implementation)
      {
      }

      public override void Interface(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> extendation)
      {
      }

      public override void InterfaceMethod(TreeNode node, Qualifier qualifier, string identifier, List<Parameter> parameters)
      {

      }

      public override void ConstDecl(TreeNode node)
      {

      }

      public override void ConstField(TreeNode node, List<string> modifiers, Qualifier qualifier, string identifier)
      {

      }

      public override void Field(TreeNode node, List<string> modifiers, Qualifier qualifier, string identifier)
      {

      }

      public override void Method(TreeNode node, List<string> modifiers, Qualifier qualifier, string identifier, List<Parameter> parameters)
      {
         ig.Emit(OpCodes.Ret);
      }

      public override void Constructor(TreeNode node, List<string> modifiers, List<Parameter> parameters)
      {
         ig.Emit(OpCodes.Ret);
      }

      public override void WhileLoop(TreeNode node)
      {
         ig.Emit(OpCodes.Br, whileStartLabels.Pop());
         ig.MarkLabel(whileEndLabels.Pop());
      }


      public override void WhileStart(TreeNode node)
      {
         Label whileLabel = ig.DefineLabel();
         whileStartLabels.Push(whileLabel);
         ig.MarkLabel(whileLabel);
      }

      public override void WhileAfterExpr(TreeNode node)
      {
         Label whileLabel = ig.DefineLabel();
         whileEndLabels.Push(whileLabel);
         ig.Emit(OpCodes.Brfalse, whileLabel);
      }

      public override void ConstantArray(TreeNode node)
      {
      }

      public override void ConstantArrayElement(TreeNode node)
      {
      }

      public override void DeclarationStatement(TreeNode node, Qualifier qualifier, string identifier)
      {
         Type localType = ((UserLocal)node.Entry.ReflectionObject).LocalType;
         LocalBuilder lb = ig.DeclareLocal(localType);
         node.Entry.ReflectionObject = lb;
      }

      public override void ObjectCreation(TreeNode node, Qualifier qualifier)
      {
         ig.Emit(OpCodes.Newobj, (ConstructorInfo)node.Entry.ReflectionObject);
         CheckStack(node, true);
      }

      public override void CallVirtual(TreeNode node, string text)
      {
         MethodInfo m = (MethodInfo)node.Entry.ReflectionObject;
         if (!m.IsStatic && m.DeclaringType.IsValueType && ((TreeNode)node.GetChild(0)).EntryType == EntryType.Method)
         {
            DeclareHiddenLocal(m.DeclaringType);
         }
         ig.Emit(OpCodes.Callvirt, m);
         CheckStack(node, true);
      }

      public override void Call(TreeNode node, string text)
      {
         MethodInfo m = (MethodInfo)node.Entry.ReflectionObject;
         if (!m.IsStatic && m.DeclaringType.IsValueType && ((TreeNode)node.GetChild(0)).EntryType == EntryType.Method)
         {
            DeclareHiddenLocal(m.DeclaringType);
         }
         ig.Emit(OpCodes.Call, m);
         CheckStack(node, true);
      }

      public override void LoadField(TreeNode node, string text)
      {
         FieldInfo f = (FieldInfo)node.Entry.ReflectionObject;
         ig.Emit(OpCodes.Ldfld, f);
         CheckStack(node, true);
      }

      public override void LoadStaticField(TreeNode node, string text)
      {
         FieldInfo f = (FieldInfo)node.Entry.ReflectionObject;
         ig.Emit(OpCodes.Ldsfld, f);
         CheckStack(node, true);
      }

      public override void LoadLiteral(TreeNode node, string text)
      {
         FieldInfo f = (FieldInfo)node.Entry.ReflectionObject;
         if (f.FieldType == typeof(int))
            ig.Emit(OpCodes.Ldc_I4, (int)node.Value);
         else if (f.FieldType == typeof(double))
            ig.Emit(OpCodes.Ldc_R8, (double)node.Value);
         else if (f.FieldType == typeof(string))
            ig.Emit(OpCodes.Ldstr, (String)node.Value);
         else if (f.FieldType == typeof(long))
            ig.Emit(OpCodes.Ldc_I8, (long)node.Value);
         else
            ig.Emit(OpCodes.Ldc_I4, (int)node.Value);

         if (((TreeNode)node.Parent).EntryType == EntryType.Method && f.FieldType.IsValueType)
         {
            ig.Emit(OpCodes.Box, f.FieldType);
         }
         CheckStack(node, true);
      }

      public override void LoadVirtualFunction(TreeNode node, string text)
      {
         MethodInfo m = (MethodInfo)node.Entry.ReflectionObject;
         ig.Emit(OpCodes.Dup);
         ig.Emit(OpCodes.Ldvirtftn, m);
         CheckStack(node, true);
      }

      public override void LoadFunction(TreeNode node, string text)
      {
         MethodInfo m = (MethodInfo)node.Entry.ReflectionObject;
         if (m.IsStatic)
            ig.Emit(OpCodes.Ldnull);

         ig.Emit(OpCodes.Ldftn, m);
         CheckStack(node, true);
      }

      public override void FieldAssignment(TreeNode node, string text)
      {
         // do nothing
      }

      public override void InvocationExpr(TreeNode node, string identifier)
      {
       /*  if ((node.Parent.Type != VnvdTreeWalker.BECOMES && node.Parent.Type != VnvdTreeWalker.ADDEVENT && node.Parent.Type != VnvdTreeWalker.REMEVENT) || node.ChildIndex == node.Parent.ChildCount - 1)
         {
            MethodInfo m;
            FieldInfo f;
            if (node.Entry.ReflectionObject is MethodInfo)
            {
               m = (MethodInfo)node.Entry.ReflectionObject;
               if (node.ReturnType is MethodType)
               {
                  if (m.IsStatic)
                     ig.Emit(OpCodes.Ldnull);

                  if (m.IsVirtual && !m.IsFinal)
                  {
                     ig.Emit(OpCodes.Dup);
                     ig.Emit(OpCodes.Ldvirtftn, m);
                  }
                  else
                     ig.Emit(OpCodes.Ldftn, m);
               }
               else
               {
                  if (!m.IsStatic && m.DeclaringType.IsValueType && ((TreeNode)node.GetChild(0)).EntryType == EntryType.Method)
                  {
                     DeclareHiddenLocal(m.DeclaringType);
                  }
                  ig.Emit(m.IsVirtual && !m.DeclaringType.IsValueType && node.GetChild(0).Type != VnvdTreeWalker.BASE ? OpCodes.Callvirt : OpCodes.Call, m);
               }
            }
            else if (node.Entry.ReflectionObject is FieldInfo)
            {
               f = (FieldInfo)node.Entry.ReflectionObject;
               if (f.IsLiteral)
               {
                  if (f.FieldType == typeof(int))
                     ig.Emit(OpCodes.Ldc_I4, (int)node.Value);
                  else if (f.FieldType == typeof(double))
                     ig.Emit(OpCodes.Ldc_R8, (double)node.Value);
                  else if (f.FieldType == typeof(string))
                     ig.Emit(OpCodes.Ldstr, (String)node.Value);
                  else if (f.FieldType == typeof(long))
                     ig.Emit(OpCodes.Ldc_I8, (long)node.Value);
                  else
                     ig.Emit(OpCodes.Ldc_I4, (int)node.Value);

                  if (node.Parent.Type == VnvdTreeWalker.DCOLON && f.FieldType.IsValueType)
                  {
                     ig.Emit(OpCodes.Box, f.FieldType);
                  }
               }
               else if (f.IsStatic)
                  ig.Emit(OpCodes.Ldsfld, f);
               else
                  ig.Emit(OpCodes.Ldfld, f);
            }
            else
            {
               throw new Exception("Debug, ERROR, should never reach this");
            }
            CheckStack(node, true);
         }*/
      }

      /// <summary>
      /// Temporary stores a variable.
      /// TempLoad() has to be called after using TempStore().
      /// </summary>
      /// <param name="t">The type of the variable</param>
      private void TempStore(Type t)
      {
         if (t.IsValueType)
            ig.Emit(OpCodes.Box, t);
         ig.Emit(OpCodes.Stloc_0);
         TempLoad(t);
      }

      /// <summary>
      /// Loads a temporary stored variable.
      /// </summary>
      /// <param name="t">The type of the variable</param>
      private void TempLoad(Type t)
      {
         ig.Emit(OpCodes.Ldloc_0);
         if (t.IsValueType)
         {
            ig.Emit(OpCodes.Unbox, t);
            ig.Emit(OpCodes.Ldobj, t);
         }
         else
            ig.Emit(OpCodes.Castclass, t);
      }

      public override void BeforeArrayElementedCreationExpr(TreeNode node)
      {
         ig.Emit(OpCodes.Ldc_I4, node.GetChild(1).ChildCount);
         ig.Emit(OpCodes.Newarr, (Type)node.Entry.ReflectionObject);
      }

      public override void BeforeArrayElementedElement(TreeNode node)
      {
         TreeNode parent = (TreeNode)node.GetAncestors()[node.GetAncestors().Count - 1];

         int id = parent.ChildCount - 1;
         bool found = false;

         while (id >= 0 && !found)
         {
            if (parent.GetChild(id) == node)
            {
               found = true;
            }
            else
            {
               id--;
            }
         }

         ig.Emit(OpCodes.Dup);
         ig.Emit(OpCodes.Ldc_I4, id);
      }

      public override void ArrayElementedElement(TreeNode node)
      {
         ig.Emit(OpCodes.Stelem, (Type)node.Entry.ReflectionObject);
      }

      public override void ArrayElementedCreationExpr(TreeNode node)
      {
      }

      public override void AssignmentExpr(TreeNode node)
      {
         bool stack = CheckStack(node, false);
         TreeNode child = (TreeNode)node.GetChild(1);
         child.ReturnType = GetRuntimeType(child.ReturnType);
         if (node.Entry.ReflectionObject is LocalBuilder)
         {
            LocalBuilder lb = (LocalBuilder)node.Entry.ReflectionObject;
            if (lb.LocalType.IsArray && !node.ReturnType.IsArray)
            {
               if (stack)
                  TempStore(child.ReturnType);

               ig.Emit(OpCodes.Stelem, lb.LocalType.GetElementType());

               if (stack)
                  TempLoad(child.ReturnType);
            }
            else
            {
               if (!lb.LocalType.IsValueType && child.ReturnType.IsValueType)
                  ig.Emit(OpCodes.Box, child.ReturnType);

               ig.Emit(OpCodes.Stloc, lb);

               if (stack)
               {
                  ig.Emit(OpCodes.Ldloc, lb);
                  if (!lb.LocalType.IsValueType && child.ReturnType.IsValueType)
                  {
                     ig.Emit(OpCodes.Unbox, child.ReturnType);
                     ig.Emit(OpCodes.Ldobj, child.ReturnType);
                  }
               }
            }
         }
         else if (node.Entry.ReflectionObject is FieldInfo)
         {
            FieldInfo fi = (FieldInfo)node.Entry.ReflectionObject;
            if (fi.FieldType.IsArray && !node.ReturnType.IsArray)
            {
               if (stack)
                  TempStore(child.ReturnType);

               ig.Emit(OpCodes.Stelem, fi.FieldType.GetElementType());

               if (stack)
                  TempLoad(child.ReturnType);
            }
            else
            {
               if (stack)
                  TempStore(child.ReturnType);

               if (!fi.FieldType.IsValueType && child.ReturnType.IsValueType)
                  ig.Emit(OpCodes.Box, child.ReturnType);

               if (fi.IsStatic)
                  ig.Emit(OpCodes.Stsfld, fi);
               else
                  ig.Emit(OpCodes.Stfld, fi);

               if (stack)
                  TempLoad(child.ReturnType);
            }
         }
         else
         {
            UserParameter lb = (UserParameter)node.Entry.ReflectionObject;
            if (lb.ParameterType.IsArray && !node.ReturnType.IsArray)
            {
               if (stack)
                  TempStore(child.ReturnType);

               ig.Emit(OpCodes.Stelem, lb.ParameterType.GetElementType());

               if (stack)
                  TempLoad(child.ReturnType);
            }
            else
            {
               if (!lb.ParameterType.IsValueType && child.ReturnType.IsValueType)
                  ig.Emit(OpCodes.Box, child.ReturnType);

               ig.Emit(OpCodes.Starg, (short)lb.Position);

               if (stack)
               {
                  ig.Emit(OpCodes.Ldarg, (short)lb.Position);
                  if (!lb.ParameterType.IsValueType && child.ReturnType.IsValueType)
                  {
                     ig.Emit(OpCodes.Unbox, child.ReturnType);
                     ig.Emit(OpCodes.Ldobj, child.ReturnType);
                  }
               }
            }
         }
      }

      public override void TernaryExpr(TreeNode node)
      {
         if (node.ChildCount == 3)
         {
            ig.MarkLabel(endLabels.Pop());
         }
         CheckStack(node, true);
      }

      public override void TernaryThen(TreeNode node)
      {
         Label elseLabel = ig.DefineLabel();
         elseLabels.Push(elseLabel);
         ig.Emit(OpCodes.Brfalse, elseLabel);
      }

      public override void TernaryElse(TreeNode node)
      {
         if (node.ChildCount == 3)
         {
            Label endLabel = ig.DefineLabel();
            endLabels.Push(endLabel);
            ig.Emit(OpCodes.Br, endLabel);
         }
         ig.MarkLabel(elseLabels.Pop());
      }

      public override void LessExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Clt);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void LessEqualExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Cgt);
            ig.Emit(OpCodes.Ldc_I4_0);
            ig.Emit(OpCodes.Ceq);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void GreaterExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Cgt);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void GreaterEqualExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Clt);
            ig.Emit(OpCodes.Ldc_I4_0);
            ig.Emit(OpCodes.Ceq);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void EqualExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Ceq);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void NotEqualExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Ceq);
            ig.Emit(OpCodes.Ldc_I4_0);
            ig.Emit(OpCodes.Ceq);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void PlusExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Add);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void MinusExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Sub);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void MultiplyExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Mul);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void DivisionExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Div);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void ModExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Rem);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void LogicNotExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Ldc_I4_0);
            ig.Emit(OpCodes.Ceq);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
         CheckStack(node, true);
      }

      public override void VariableUsed(TreeNode node, Qualifier qual)
      {
         if (node.Parent.Type != VnvdTreeWalker.BECOMES || node.ChildIndex == node.Parent.ChildCount - 1)
         {
            if (node.Entry.ReflectionObject is LocalBuilder)
            {
               LocalBuilder lb = (LocalBuilder)node.Entry.ReflectionObject;
               if (lb.LocalType.IsPrimitive && ((TreeNode)node.Parent).EntryType == EntryType.Method)
               {
                  ig.Emit(OpCodes.Ldloca, lb);
               }
               else
               {
                  ig.Emit(OpCodes.Ldloc, lb);
               }
            }
            else if (node.Entry.ReflectionObject is ParameterInfo)
            {
               ParameterInfo lb = (ParameterInfo)node.Entry.ReflectionObject;
               if (lb.ParameterType.IsPrimitive && ((TreeNode)node.Parent).EntryType == EntryType.Method)
               {
                  ig.Emit(OpCodes.Ldarga, (short)lb.Position);
               }
               else
               {
                  ig.Emit(OpCodes.Ldarg, (short)lb.Position);
               }
            }
            else if (node.Entry.ReflectionObject is UserLocal)
            {
               Type t = ((UserLocal)node.Entry.ReflectionObject).LocalType;
               if (node.Value == null)
               {
                  // doe niets, array acces hier
               }
               else if (t.Equals(typeof(Int32)))
               {
                  this.LiteralNumber(node);
               }
               else if (t.Equals(typeof(Double)))
               {
                  this.LiteralFloat(node);
               }
               else if (t.Equals(typeof(String)))
               {
                  this.LiteralString(node);
               }
               else if (t.Equals(typeof(Char)))
               {
                  this.LiteralCharacter(node);
               }
               else if (t.Equals(typeof(Boolean)))
               {
                  this.LiteralBoolean(node);
               }
            }
            CheckStack(node, true);
         }
      }

      public override void ExpressionBlock(TreeNode node)
      {

      }

      public override void StatementBlock(TreeNode node)
      {
         CheckStack(node, true);
      }

      private void DeclareHiddenLocal(Type type)
      {
         if (!hiddenLocals.ContainsKey(type))
         {
            hiddenLocals[type] = ig.DeclareLocal(type);
         }
         LocalBuilder lb2 = hiddenLocals[type];
         ig.Emit(OpCodes.Stloc, lb2);
         ig.Emit(OpCodes.Ldloca, lb2);
      }

      public override void LiteralNumber(TreeNode node)
      {
         if (node.Value != null)
         {
            ig.Emit(OpCodes.Ldc_I4, (Int32)node.Value);

            if (((TreeNode)node.Parent).EntryType == EntryType.Method)
            {
               DeclareHiddenLocal(typeof(Int32));
            }

            CheckStack(node, true);
         }
      }

      public override void LiteralFloat(TreeNode node)
      {
         ig.Emit(OpCodes.Ldc_R8, (Double)node.Value);

         if (((TreeNode)node.Parent).EntryType == EntryType.Method)
         {
            DeclareHiddenLocal(typeof(Double));
         }

         CheckStack(node, true);
      }

      public override void LiteralString(TreeNode node)
      {
         ig.Emit(OpCodes.Ldstr, (String)node.Value);

         if (((TreeNode)node.Parent).EntryType == EntryType.Method)
         {
            DeclareHiddenLocal(typeof(String));
         }

         CheckStack(node, true);
      }

      public override void LiteralCharacter(TreeNode node)
      {
         ig.Emit(OpCodes.Ldc_I4, (Char)node.Value);

         if (((TreeNode)node.Parent).EntryType == EntryType.Method)
         {
            DeclareHiddenLocal(typeof(Char));
         }

         CheckStack(node, true);
      }

      public override void LiteralBoolean(TreeNode node)
      {
         if ((Boolean)node.Value)
            ig.Emit(OpCodes.Ldc_I4_1);
         else
            ig.Emit(OpCodes.Ldc_I4_0);

         if (((TreeNode)node.Parent).EntryType == EntryType.Method)
         {
            DeclareHiddenLocal(typeof(Boolean));
         }

         CheckStack(node, true);
      }

      public override void BeginClass(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> qualifiers, List<Qualifier> list1)
      {
         tb = (TypeBuilder)node.Entry.ReflectionObject;
      }

      public override void BeginInterface(TreeNode node, List<string> modifiers, Qualifier qualifier, List<Qualifier> qualifiers)
      {
         tb = (TypeBuilder)node.Entry.ReflectionObject;
      }

      public override void BeginMethod(TreeNode node, List<string> modifiers, Qualifier return_, string name, List<Parameter> parameters)
      {
         metb = (MethodBuilder)node.Entry.ReflectionObject;
         ig = metb.GetILGenerator();
         ig.DeclareLocal(typeof(object));
         ig.Emit(OpCodes.Nop);
      }

      public override void BeginConstructor(TreeNode node, List<string> list, List<Parameter> parameters, TreeNode bas)
      {
         ConstructorInfo baseCons;
         if (bas != null)
         {
            baseCons = (ConstructorInfo)bas.Entry.ReflectionObject;
         }
         else
         {
            TreeNode child = (TreeNode)node.GetChild(1);
            baseCons = (ConstructorInfo)child.Entry.ReflectionObject;
         }
         ig.Emit(OpCodes.Call, baseCons);
      }

      public override void BeginConstructorBeforeBaseCall(TreeNode node)
      {
         cb = (ConstructorBuilder)node.Entry.ReflectionObject;
         ig = cb.GetILGenerator();
         ig.DeclareLocal(typeof(object));
      }

      public override void BeginProgram(TreeNode node)
      {

      }

      public override void ScopeExpr(TreeNode node)
      {
         CheckStack(node, true);
      }

      public override void LiteralThis(TreeNode node)
      {
         ig.Emit(OpCodes.Ldarg_0);

         CheckStack(node, true);
      }

      public override void LiteralBase(TreeNode node)
      {
         ig.Emit(OpCodes.Ldarg_0);

         CheckStack(node, true);
      }

      public override void OpenScope()
      {
         ig.BeginScope();
      }

      public override void CloseScope()
      {
         ig.EndScope();
      }

      private bool CheckStack(TreeNode node, Boolean pop)
      {
         if ((node.Parent.Type == VnvdTreeWalker.SLIST || node.Parent.Type == VnvdTreeWalker.SCOPEEXPR) &&
            (node.ChildIndex != node.Parent.ChildCount - 1 ||
            (node.Parent.Parent.Type == VnvdTreeWalker.METHOD && ((MethodInfo)((TreeNode)node.Parent.Parent).Entry.ReflectionObject).ReturnType == typeof(void)) ||
            node.Parent.Parent.Type == VnvdTreeWalker.CONSTRUCTOR || node.Parent.Parent.Type == VnvdTreeWalker.SCONSTRUCTOR) &&
            node.ReturnType != typeof(void))
         {
            if (pop) ig.Emit(OpCodes.Pop);
            return false;
         }
         if ((node.Parent.Type == VnvdTreeWalker.IF || node.Parent.Type == VnvdTreeWalker.WHILE || node.Parent.Type == VnvdTreeWalker.ICATCH) && node.ChildIndex != 0 && node.ReturnType != typeof(void) && ((TreeNode)node.Parent).ReturnType == typeof(void))
         {
            if (pop) ig.Emit(OpCodes.Pop);
            return false;
         }
         if ((node.Parent.Type == VnvdTreeWalker.FOR) && node.ChildIndex == 2 && node.ReturnType != typeof(void) && ((TreeNode)node.Parent).ReturnType == typeof(void))
         {
            if (pop) ig.Emit(OpCodes.Pop);
            return false;
         }
         if ((node.Parent.Type == VnvdTreeWalker.TRY || node.Parent.Type == VnvdTreeWalker.FINALLY) && node.ChildIndex == 0 && node.ReturnType != typeof(void) && ((TreeNode)node.Parent).ReturnType == typeof(void))
         {
            if (pop) ig.Emit(OpCodes.Pop);
            return false;
         }
         return true;
      }

      public override void LiteralNull(TreeNode node)
      {
         ig.Emit(OpCodes.Ldnull);
         CheckStack(node, true);
      }


      public override void CastExpression(TreeNode node, Qualifier qual)
      {
         Type dest = (Type)node.Entry.ReflectionObject;
         Type src = ((TreeNode)node.GetChild(1)).ReturnType;
         if (src is UserType)
            src = (Type)((UserType)src).Entry.ReflectionObject;

         if (src.IsValueType && dest == typeof(object))
         {
            ig.Emit(OpCodes.Box, src);
         }
         else if (src == typeof(object) && dest.IsValueType)
         {
            ig.Emit(OpCodes.Unbox, dest);
            ig.Emit(OpCodes.Ldobj, dest);
         }
         else if (src.IsPrimitive && dest.IsPrimitive)
         {
            if (dest == typeof(int) || dest == typeof(char))
               ig.Emit(OpCodes.Conv_I4);
            else if (dest == typeof(byte))
               ig.Emit(OpCodes.Conv_I1);
            else if (dest == typeof(double))
               ig.Emit(OpCodes.Conv_R8);
         }
         else
         {
            ig.Emit(OpCodes.Castclass, dest);
         }
      }

      public override void CastAsExpression(TreeNode node, Qualifier qual)
      {
         ig.Emit(OpCodes.Isinst, (Type)node.Entry.ReflectionObject);
      }

      public override void UnaryPlusExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject != null)
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
      }

      public override void UnaryMinusExpr(TreeNode node)
      {
         if (node.Entry.ReflectionObject == null)
         {
            ig.Emit(OpCodes.Neg);
         }
         else
         {
            ig.Emit(OpCodes.Call, (MethodInfo)node.Entry.ReflectionObject);
         }
      }

      public override void BeginTry(TreeNode node)
      {
         ig.BeginExceptionBlock();
      }

      public override void EndTry(TreeNode node)
      {
         ig.EndExceptionBlock();
      }

      public override void BeginCatch(TreeNode node, TreeNode node2, Qualifier qual, string p)
      {
         LocalBuilder l = (LocalBuilder)node2.Entry.ReflectionObject;
         ig.BeginCatchBlock(l.LocalType);
         ig.Emit(OpCodes.Stloc, l);
      }

      public override void EndCatch(TreeNode node, Qualifier qual, string p)
      {

      }

      public override void BeginFinally(TreeNode node)
      {
         ig.BeginFinallyBlock();
      }

      public override void EndFinally(TreeNode node)
      {
      }

      public override void ConstantDeclaration(TreeNode node, Qualifier qual, string p)
      {
         //TreeNode literal = (TreeNode)node.GetChild(2);
      }

      public override void AccessArray(TreeNode node)
      {
         if (node.Parent.Type != VnvdTreeWalker.BECOMES || node.ChildIndex == node.Parent.ChildCount - 1)
         {
            if (node.EntryType == EntryType.Constant)
            {
               Type t = ((UserLocal)node.Entry.ReflectionObject).LocalType.GetElementType();
               if (t.Equals(typeof(Int32)))
               {
                  this.LiteralNumber(node);
               }
               else if (t.Equals(typeof(Double)))
               {
                  this.LiteralFloat(node);
               }
               else if (t.Equals(typeof(String)))
               {
                  this.LiteralString(node);
               }
               else if (t.Equals(typeof(Char)))
               {
                  this.LiteralCharacter(node);
               }
               else if (t.Equals(typeof(Boolean)))
               {
                  this.LiteralBoolean(node);
               }
            }
            else
            {
               ig.Emit(OpCodes.Ldelem, GetRuntimeType(node.ReturnType));
            }
         }
      }

      /// <summary>
      /// Returns the runtime type of the given type.
      /// </summary>
      /// <param name="t">The type</param>
      /// <returns>The runtime type</returns>
      public Type GetRuntimeType(Type t)
      {
         if (t is NullType)
            return typeof (Object);
         if (t is UserType)
            return (Type)((UserType)t).Entry.ReflectionObject;
         else
            return t;
      }

      public override void ConstLiteralNumber(TreeNode node)
      {        
      }

      public override void ConstLiteralFloat(TreeNode node)
      {      
      }

      public override void ConstLiteralCharacter(TreeNode node)
      {
      }

      public override void ConstLiteralBoolean(TreeNode node)
      {
      }

      public override void ConstLiteralString(TreeNode node)
      {
      }

      public override void ArrayCreationExpr(TreeNode node)
      {
         ig.Emit(OpCodes.Newarr, (Type)node.Entry.ReflectionObject);
      }

      public override void ThrowStatement(TreeNode node)
      {
         ig.Emit(OpCodes.Throw);
      }

      public override void AbstractMethod(TreeNode node, List<string> list, Qualifier return_, string p, List<Parameter> list_5)
      {
      }

      public override void BeginFor(TreeNode node, TreeNode node2, Qualifier qual, string p)
      {
         ig.Emit(OpCodes.Callvirt, typeof(IEnumerable).GetMethod("GetEnumerator"));

         Label forEnd = ig.DefineLabel();
         forEndLabels.Push(forEnd);

         Label forLabel = ig.DefineLabel();
         forStartLabels.Push(forLabel);
         ig.MarkLabel(forLabel);
         ig.Emit(OpCodes.Dup);
         ig.Emit(OpCodes.Callvirt, typeof(IEnumerator).GetMethod("MoveNext"));
         ig.Emit(OpCodes.Brfalse, forEnd);
         ig.Emit(OpCodes.Dup);
         ig.Emit(OpCodes.Callvirt, typeof(IEnumerator).GetMethod("get_Current"));
         LocalBuilder l = (LocalBuilder)node2.Entry.ReflectionObject;
         if (l.LocalType.IsValueType)
         {
            ig.Emit(OpCodes.Unbox, l.LocalType);
            ig.Emit(OpCodes.Ldobj, l.LocalType);
         }
         else
            ig.Emit(OpCodes.Castclass, l.LocalType);

         ig.Emit(OpCodes.Stloc, l);
      }

      public override void ForLoop(TreeNode node)
      {
         ig.Emit(OpCodes.Br, forStartLabels.Pop());
         ig.MarkLabel(forEndLabels.Pop());
         ig.Emit(OpCodes.Pop);
      }

      public override void ReadExpression(TreeNode node, String identifier)
      {
         bool stack = CheckStack(node, false);
         LocalBuilder lb = (LocalBuilder)node.Entry.ReflectionObject;

         if (lb.LocalType == typeof(char))
         {
            if (!hiddenLocals.ContainsKey(typeof(ConsoleKeyInfo)))
            {
               hiddenLocals[typeof(ConsoleKeyInfo)] = ig.DeclareLocal(typeof(ConsoleKeyInfo));
            }
            LocalBuilder lb2 = hiddenLocals[typeof(ConsoleKeyInfo)];
            ig.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadKey", Type.EmptyTypes));

            ig.Emit(OpCodes.Stloc, lb2);
            ig.Emit(OpCodes.Ldloca, lb2);

            ig.Emit(OpCodes.Call, typeof(ConsoleKeyInfo).GetMethod("get_KeyChar"));
         }
         else if (lb.LocalType == typeof(int))
         {
            ig.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadLine"));
            ig.Emit(OpCodes.Call, typeof(Int32).GetMethod("Parse", new Type[] { typeof(string) }));
         }
         else if (lb.LocalType == typeof(bool))
         {
            ig.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadLine"));
            ig.Emit(OpCodes.Call, typeof(Boolean).GetMethod("Parse", new Type[] { typeof(string) }));
         }
         else
         {
            ig.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadLine"));
         }

         //if (lb.LocalType == typeof(object) && child.ReturnType.IsValueType)
         //    ig.Emit(OpCodes.Box, child.ReturnType);

         ig.Emit(OpCodes.Stloc, lb);

         if (stack)
            ig.Emit(OpCodes.Ldloc, lb);
      }

      public override void ReadVoidExpression(TreeNode node, String identifier)
      {
         //TreeNode child = (TreeNode)node.GetChild(1);
         LocalBuilder lb = (LocalBuilder)node.Entry.ReflectionObject;

         if (lb.LocalType == typeof(char))
         {
            if (!hiddenLocals.ContainsKey(typeof(ConsoleKeyInfo)))
            {
               hiddenLocals[typeof(ConsoleKeyInfo)] = ig.DeclareLocal(typeof(ConsoleKeyInfo));
            }
            LocalBuilder lb2 = hiddenLocals[typeof(ConsoleKeyInfo)];
            ig.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadKey", Type.EmptyTypes));

            ig.Emit(OpCodes.Stloc, lb2);
            ig.Emit(OpCodes.Ldloca, lb2);

            //ig.Emit(OpCodes.Box, typeof(ConsoleKeyInfo));
            ig.Emit(OpCodes.Call, typeof(ConsoleKeyInfo).GetMethod("get_KeyChar"));
         }
         else if (lb.LocalType == typeof(int))
         {
            ig.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadLine"));
            ig.Emit(OpCodes.Call, typeof(Int32).GetMethod("Parse", new Type[] { typeof(string) }));
         }
         else if (lb.LocalType == typeof(bool))
         {
            ig.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadLine"));
            ig.Emit(OpCodes.Call, typeof(Boolean).GetMethod("Parse", new Type[] { typeof(string) }));
         }
         else
         {
            ig.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadLine"));
         }

         //if (lb.LocalType == typeof(object) && child.ReturnType.IsValueType)
         //    ig.Emit(OpCodes.Box, child.ReturnType);

         ig.Emit(OpCodes.Stloc, lb);
      }

      public override void WriteExpression(TreeNode node)
      {
         if (CheckStack(node, false))
            ig.Emit(OpCodes.Dup);

         TreeNode child = (TreeNode)node.Children[0];
         Type returnType = GetRuntimeType(child.ReturnType);
         if (returnType.IsValueType)
         {
            ig.Emit(OpCodes.Box, returnType);
         }
         ig.Emit(OpCodes.Call, typeof(Console).GetMethod("Write", new Type[] { typeof(Object) }));
      }

      public override void WriteVoidExpression(TreeNode node)
      {
         TreeNode child = (TreeNode)node.Children[0];
         Type returnType = GetRuntimeType(child.ReturnType);
         if (returnType.IsValueType)
         {
            ig.Emit(OpCodes.Box, returnType);
         }
         ig.Emit(OpCodes.Call, typeof(Console).GetMethod("Write", new Type[] { typeof(Object) }));
      }

      public override void AddEventExpr(TreeNode node)
      {
         EventInfo e = (EventInfo)node.Entry.ReflectionObject;
         MethodInfo m = e.GetAddMethod();
         ig.Emit(m.IsVirtual ? OpCodes.Callvirt : OpCodes.Call, m);
      }

      public override void RemoveEventExpr(TreeNode node)
      {
         EventInfo e = (EventInfo)node.Entry.ReflectionObject;
         MethodInfo m = e.GetRemoveMethod();
         ig.Emit(m.IsVirtual ? OpCodes.Callvirt : OpCodes.Call, m);
      }

      public override void LogicOrExpr(TreeNode node)
      {
         ig.Emit(OpCodes.Or);
         CheckStack(node, true);
      }

      public override void LogicXorExpr(TreeNode node)
      {
         ig.Emit(OpCodes.Xor);
         CheckStack(node, true);
      }

      public override void LogicAndExpr(TreeNode node)
      {
         ig.Emit(OpCodes.And);
         CheckStack(node, true);
      }

      public override void BeginCondOr(TreeNode node)
      {
         condOrLabelsTrue.Push(ig.DefineLabel());
         condOrLabelsFalse.Push(ig.DefineLabel());
      }

      public override void MiddleCondOr(TreeNode node)
      {
         ig.Emit(OpCodes.Brtrue, condOrLabelsTrue.Peek());
      }

      public override void BeginCondAnd(TreeNode node)
      {
         condAndLabelsTrue.Push(ig.DefineLabel());
         condAndLabelsFalse.Push(ig.DefineLabel());
      }

      public override void MiddleCondAnd(TreeNode node)
      {
         ig.Emit(OpCodes.Brfalse, condAndLabelsFalse.Peek());
      }

      public override void EndConditionalOrExpr(TreeNode node)
      {
         ig.Emit(OpCodes.Br, condOrLabelsFalse.Peek());
         ig.MarkLabel(condOrLabelsTrue.Pop());
         ig.Emit(OpCodes.Ldc_I4_1);
         ig.MarkLabel(condOrLabelsFalse.Pop());
         CheckStack(node, true);
      }

      public override void EndConditionalAndExpr(TreeNode node)
      {
         ig.Emit(OpCodes.Br, condAndLabelsTrue.Peek());
         ig.MarkLabel(condAndLabelsFalse.Pop());
         ig.Emit(OpCodes.Ldc_I4_0);
         ig.MarkLabel(condAndLabelsTrue.Pop());
         CheckStack(node, true);
      }

      public override void IsTypeExpression(TreeNode node, Qualifier qual)
      {
         ig.Emit(OpCodes.Isinst, (Type)node.Entry.ReflectionObject);
         ig.Emit(OpCodes.Ldnull);
         ig.Emit(OpCodes.Cgt_Un);
      }

      public override void BeginStaticConstructor(TreeNode node)
      {
         cb = (ConstructorBuilder)node.Entry.ReflectionObject;
         ig = cb.GetILGenerator();
         ig.DeclareLocal(typeof(object));
         ig.Emit(OpCodes.Nop);
      }

      public override void EndStaticConstructor(TreeNode node)
      {
         ig.Emit(OpCodes.Ret);
      }

     
   }
}