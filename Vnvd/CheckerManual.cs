using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection;
using System.Text;
using Antlr.Runtime.Tree;
using Vnvd.Antlr;
using Vnvd.UserDefined;

namespace Vnvd
{
   /// <summary>
   /// The class to manually walk parts of the AST and define classes and class members
   /// </summary>
   class CheckerManual
   {
      private List<TreeNode> types = new List<TreeNode>();
      private List<UserType> userTypes = new List<UserType>();
      private List<TreeNode> reorderedTypes;
      private LibraryChecker lib;
      private List<String> searchPath;
      private UserType currentType;

      /// <summary>
      /// Creates a new CheckManual instance
      /// </summary>
      public CheckerManual()
      {
         lib = Vnvd.Library;
      }

      /// <summary>
      /// Manually walk the node and define all classes and interfaces found
      /// </summary>
      /// <param name="node">The parent node where to start searching for classes and interfaces</param>
      public void WalkClasses(TreeNode node)
      {
         CheckerException exc = new CheckerException();

         node.Entry = new IdEntry();
         List<String> using_ = new List<String>();
         node.Entry.ReflectionObject = using_;

         // manually traverse the AST so we can first define all classes before references to them are made
         foreach (TreeNode n in node.Children)
         {
            if (n.Type == VnvdTreeWalker.USING)
            {
               using_.Add(AbstractHelper.GetFullQualifier(n.GetChild(0)).ToString());
            }
            else if (n.Type == VnvdTreeWalker.NAMESPACE)
            {
               Qualifier q = AbstractHelper.GetFullQualifier(n.GetChild(0));
               string ns = q.ToString();

               foreach (TreeNode n2 in n.Children)
               {
                  try
                  {
                     if (n2.Type == VnvdTreeWalker.CLASS)
                     {
                        n2.EntryType = EntryType.Class;
                        n2.Entry = new IdEntry();
                        UserType t = DefineClass(ns, AbstractHelper.GetFullQualifier(n2.GetChild(1)).ToString(), AbstractHelper.GetModifiers(n2.GetChild(0)));
                        n2.Entry.ReflectionObject = t;
                        t.Entry = n2.Entry;
                        if (IsAlreadyDefined(t.Name, t.Namespace))
                           throw new CheckerException(n2, "A type with the same name '" + t.FullName + "' already exists");
                        userTypes.Add(t);
                        types.Add(n2);
                     }
                     else if (n2.Type == VnvdTreeWalker.INTERFACE)
                     {
                        n2.EntryType = EntryType.Interface;
                        n2.Entry = new IdEntry();
                        UserType t = DefineInterface(ns, AbstractHelper.GetFullQualifier(n2.GetChild(1)).ToString(), AbstractHelper.GetModifiers(n2.GetChild(0)));
                        n2.Entry.ReflectionObject = t;
                        t.Entry = n2.Entry;
                        if (IsAlreadyDefined(t.Name, t.Namespace))
                           throw new CheckerException(n2, "A type with the same name '" + t.FullName + "' already exists");
                        userTypes.Add(t);
                        types.Insert(0, n2);
                     }
                     else if (n2.Type == VnvdTreeWalker.ENUM)
                     {
                        n2.EntryType = EntryType.Enum;
                        n2.Entry = new IdEntry();
                        UserType t = DefineEnum(ns, AbstractHelper.GetFullQualifier(n2.GetChild(1)).ToString(), AbstractHelper.GetModifiers(n2.GetChild(0)));
                        n2.Entry.ReflectionObject = t;
                        t.Entry = n2.Entry;
                        if (IsAlreadyDefined(t.Name, t.Namespace))
                           throw new CheckerException(n2, "A type with the same name '" + t.FullName + "' already exists");
                        userTypes.Add(t);
                        types.Insert(0, n2);
                     }
                  }
                  catch (CheckerException ex)
                  {
                     exc.AddError(n2, ex.GetLastError().Second);
                  }
               }
            }
         }

         lib.CustomTypes = userTypes.ToArray();

         if (exc.ErrorCount > 0)
            throw exc;
      }

      /// <summary>
      /// Now walk the previously defined types and check each extends and implements
      /// </summary>
      public void WalkClassExtendation()
      {
         CheckerException exc = new CheckerException();
         reorderedTypes = new List<TreeNode>(types);

         for (int i = 0; i < types.Count; i++)
         {
            TreeNode n = types[i];
            currentType = (UserType)n.Entry.ReflectionObject;
            searchPath = (List<string>)((TreeNode) n.Parent.Parent).Entry.ReflectionObject;
            searchPath.Add(currentType.Namespace);

            Qualifier extends;
            List<Qualifier> implements;
            if (n.GetChild(2) != null)
            {
               if (n.GetChild(2).Type == VnvdTreeWalker.EXTENDS)
               {
                  extends = AbstractHelper.GetFullQualifier(n.GetChild(2).GetChild(0));
                  if (n.GetChild(3) != null && n.GetChild(3).Type == VnvdTreeWalker.IMPLEMENTS)
                  {
                     implements = AbstractHelper.GetImplements(n.GetChild(3));
                  }
                  else
                  {
                     implements = new List<Qualifier>();
                  }
               }
               else if (n.GetChild(2).Type == VnvdTreeWalker.IMPLEMENTS)
               {
                  implements = AbstractHelper.GetImplements(n.GetChild(2));
                  extends = new Qualifier() { "System", "Object" };
               }
               else
               {
                  extends = new Qualifier() { "System", "Object" };
                  implements = new List<Qualifier>();
               }
            }
            else
            {
               extends = new Qualifier() { "System", "Object" };
               implements = new List<Qualifier>();
            }

            try
            {
               IdEntry ext = this.GetTypeIdEntry(extends.ToString());
               Type extType = (Type) ext.ReflectionObject;

               if (currentType.IsInterface && ext.ReflectionObject != typeof(object) && !((Type)ext.ReflectionObject).IsInterface)
                  throw new CheckerException(n, "An interface can only extend another interface, not a class: " + ((Type)ext.ReflectionObject).FullName);
               if (!currentType.IsInterface && !extType.IsClass)
                  throw new CheckerException(n, "Cannot extend interface or value type " + extType.FullName);
               if (extType.IsSubclassOf(currentType))
                  throw new CheckerException(n, "Circular extendation detected at " + extType.FullName + " and " + currentType.FullName);
               if (extType.IsSealed)
                  throw new CheckerException(n, "Cannot extend types marked as sealed: " + extType.FullName);
               if (currentType.IsInterface && ext.ReflectionObject != typeof(object))
                  implements.Add(extends);
               else if (!currentType.IsInterface && !currentType.IsEnum)
                  currentType.SetBaseType(ext);

               for (int j = i + 1; j < reorderedTypes.Count; j++)
               {
                  if (reorderedTypes[j].Entry.ReflectionObject == ext.ReflectionObject)
                  {
                     TreeNode temp = reorderedTypes[j];
                     reorderedTypes.Remove(temp);
                     reorderedTypes.Insert(i, temp);
                  }
               }
            }
            catch (CheckerException ex)
            {
               exc.AddError(n, ex.GetLastError().Second);
            }

            try
            {
               foreach (var implement in implements)
               {
                  IdEntry imple = this.GetTypeIdEntry(implement.ToString());
                  Type t = (Type)imple.ReflectionObject;
                  if (!t.IsInterface)
                     throw new CheckerException(n, "Cannot implement a class or value type " + t.FullName);
                  currentType.AddInterface(imple);
               }
            }
            catch (CheckerException ex)
            {
               exc.AddError(n, ex.GetLastError().Second);
            }

            this.searchPath.Remove(currentType.Namespace);
         }

         if (exc.ErrorCount > 0)
            throw exc;
      }

      /// <summary>
      /// Finally walk all members of the classes and interfaces. Methods etc. are defined here
      /// </summary>
      public void WalkClassMembers()
      {
         CheckerException exc = new CheckerException();
         bool hasMain = false;
         for (int i = 0; i < reorderedTypes.Count; i++)
         {
            TreeNode n = reorderedTypes[i];
            currentType = (UserType)n.Entry.ReflectionObject;
            searchPath = (List<string>)((TreeNode)n.Parent.Parent).Entry.ReflectionObject;
            this.searchPath.Add(currentType.Namespace);

            foreach (TreeNode n2 in n.Children)
            {
               try
               {
                  if (n2.Type == VnvdTreeWalker.FIELD)
                  {
                     n2.EntryType = EntryType.Variable;
                     IdEntry entry = new IdEntry();
                     entry.Node = n2;
                     string ret = n2.GetChild(1).Type == VnvdTreeWalker.FQUALIFIER
                                     ? AbstractHelper.GetFullQualifier(n2.GetChild(1)).ToString()
                                     : n2.GetChild(1).Text;
                     UserField field = DefineField(currentType, n2.GetChild(2).Text, AbstractHelper.GetModifiers(n2.GetChild(0)),
                                                          ret);
                     field.Entry = entry;
                     entry.ReflectionObject = field;
                     n2.Entry = entry;
                  }
                  else if (n2.Type == VnvdTreeWalker.CONSTRUCTOR)
                  {
                     n2.EntryType = EntryType.Constructor;
                     IdEntry entry = new IdEntry();
                     entry.Node = n2;

                     String[] parNames = AbstractHelper.GetParameterNames(n2.GetChild(2));
                     String[] parTypes = AbstractHelper.GetParameterTypes(n2.GetChild(2));

                     UserConstructor cons = DefineConstructor(currentType, AbstractHelper.GetModifiers(n2.GetChild(0)), parTypes, parNames);
                     cons.Entry = entry;
                     entry.ReflectionObject = cons;
                     n2.Entry = entry;
                  }
                  else if (n2.Type == VnvdTreeWalker.METHOD)
                  {
                     n2.EntryType = EntryType.Method;
                     IdEntry entry = new IdEntry();
                     entry.Node = n2;

                     String[] parNames = AbstractHelper.GetParameterNames(n2.GetChild(3));
                     String[] parTypes = AbstractHelper.GetParameterTypes(n2.GetChild(3));

                     string ret = n2.GetChild(1).Type == VnvdTreeWalker.FQUALIFIER
                         ? AbstractHelper.GetFullQualifier(n2.GetChild(1)).ToString()
                         : n2.GetChild(1).Text;

                     UserMethod met = DefineMethod(currentType, n2.GetChild(2).Text, AbstractHelper.GetModifiers(n2.GetChild(0)), ret, parTypes, parNames);
                     if (met.Name.Equals(GeneratorManual.MAINMETHOD))
                     {
                        if (hasMain)
                           throw new CheckerException(n2, "Duplicate main method.");
                        hasMain = true;
                     }
                     met.Entry = entry;
                     entry.ReflectionObject = met;
                     n2.Entry = entry;
                  }
                  else if (n2.Type == VnvdTreeWalker.IMETHOD)
                  {
                     n2.EntryType = EntryType.Method;
                     IdEntry entry = new IdEntry();
                     entry.Node = n2;

                     String[] parNames = AbstractHelper.GetParameterNames(n2.GetChild(2));
                     String[] parTypes = AbstractHelper.GetParameterTypes(n2.GetChild(2));

                     string ret = n2.GetChild(0).Type == VnvdTreeWalker.FQUALIFIER
                         ? AbstractHelper.GetFullQualifier(n2.GetChild(0)).ToString()
                         : n2.GetChild(0).Text;

                     UserMethod met = DefineInterfaceMethod(currentType, n2.GetChild(1).Text, ret, parTypes, parNames);
                     met.Entry = entry;
                     entry.ReflectionObject = met;
                     n2.Entry = entry;
                  }
                  else if (n2.Type == VnvdTreeWalker.SCONSTRUCTOR)
                  {
                     n2.EntryType = EntryType.Constructor;
                     IdEntry entry = new IdEntry();
                     entry.Node = n2;
                     UserConstructor cons = currentType.DefineTypeInitializer();
                     cons.Entry = entry;
                     entry.ReflectionObject = cons;
                     n2.Entry = entry;
                  }
                  else if (n2.Type == VnvdTreeWalker.ENUMOPTION)
                  {
                     n2.EntryType = EntryType.Variable;
                     IdEntry entry = new IdEntry();
                     entry.Node = n2;
                     UserField option = ((UserEnum)currentType).DefineOption(n2.GetChild(0).Text);
                     option.Entry = entry;
                     entry.ReflectionObject = option;
                     n2.Entry = entry;
                  }
               }
               catch (CheckerException ex)
               {
                  exc.AddError(n2, ex.GetLastError().Second);
               }
               catch (InvalidOperationException ex)
               {
                  exc.AddError(n2, ex.Message);
               }
               catch (SymbolTableException ex)
               {
                  exc.AddError(n2, ex.Message);
               }
            }

            if (currentType.IsClass && currentType.GetConstructors().Length == 0)
            {
               UserConstructor uc = DefineConstructor(currentType, new List<string>() { "public" }, new string[] {}, new string[] {});
               uc.Entry = new IdEntry();
               uc.Entry.ReflectionObject = uc;
            }

            try
            {
               if (!currentType.IsInterface)
                  currentType.CheckInterfaces();
            }
            catch (CheckerException ex)
            {
               exc.AddError(n, ex.GetLastError().Second);
            }

            this.searchPath.Remove(currentType.Namespace);
         }

         if (exc.ErrorCount > 0)
            throw exc;
      }

      private UserConstructor DefineConstructor(UserType type, List<string> modifiers, String[] parTypes, String[] parNames)
      {
         MethodAttributes attr = MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName;
         foreach (String s in modifiers)
         {
            attr |= (MethodAttributes)Enum.Parse(typeof(MethodAttributes), s, true);
         }

         IdEntry[] pars = new IdEntry[parTypes.Length];
         for (int i = 0; i < parTypes.Length; i++)
         {
            pars[i] = this.GetTypeIdEntry(parTypes[i]);
         }
         UserConstructor cb = type.DefineConstructor(attr, pars, parNames);

         return cb;
      }

      private UserField DefineField(UserType type, String name, List<string> modifiers, String _return)
      {
         FieldAttributes attr = 0;
         foreach (String s in modifiers)
         {
            attr |= (FieldAttributes)Enum.Parse(typeof(FieldAttributes), s, true);
         }
         IdEntry ret = this.GetTypeIdEntry(_return);
         return type.DefineField(name, attr, ret);
      }

      private UserMethod DefineMethod(UserType type, String name, List<string> modifiers, String _return, String[] parTypes, String[] parNames)
      {
         bool overrid = modifiers.Remove("override");
         if (overrid)
            modifiers.Add("virtual");
         if (!type.IsAbstract && modifiers.Contains("abstract"))
            throw new CheckerException("Cannot declare abstract method " + name + " in a non-abstract class: " + type.Name);
         if (modifiers.Contains("abstract"))
            modifiers.Add("virtual");
         MethodAttributes attr = MethodAttributes.HideBySig;
         foreach (String s in modifiers)
         {
            attr |= (MethodAttributes)Enum.Parse(typeof(MethodAttributes), s, true);
         }

         IdEntry[] pars = new IdEntry[parTypes.Length];
         for (int i = 0; i < parTypes.Length; i++)
         {
            pars[i] = this.GetTypeIdEntry(parTypes[i]);
         }
         IdEntry ret = KeywordToType(_return) != null ? new IdEntry() { ReflectionObject = KeywordToType(_return) } : this.GetTypeIdEntry(_return);

         if (overrid)
         {
            MethodInfo m = type.BaseType.GetMethod(name, BindingFlags.FlattenHierarchy | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, LibraryChecker.ToArray<Type>(pars), null);
            if (m == null || m.ReturnType != ret.ReflectionObject)
               throw new CheckerException("No suitable method found to override: " + name);
            if (!m.IsVirtual)
               throw new CheckerException("Cannot override a non-virtual method: " + m.Name);

         }
         else
         {
            MethodInfo m = type.GetMethod(name, BindingFlags.FlattenHierarchy | BindingFlags.ExactBinding | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, LibraryChecker.ToArray<Type>(pars), null);
            if (m != null)
               throw new CheckerException("Method already exists: " + m.Name);
            if (type.GetInterfaceMethod(name, LibraryChecker.ToArray<Type>(pars)) != null)
               attr |= MethodAttributes.NewSlot | MethodAttributes.Virtual;
         }
         UserMethod metb = type.DefineMethod(name, attr, ret, pars, parNames);

         return metb;
      }

      private UserMethod DefineInterfaceMethod(UserType type, string name, string _return, string[] parTypes, string[] parNames)
      {
         MethodAttributes attr = MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.Abstract | MethodAttributes.NewSlot | MethodAttributes.Virtual;

         IdEntry[] pars = new IdEntry[parTypes.Length];
         for (int i = 0; i < parTypes.Length; i++)
         {
            pars[i] = this.GetTypeIdEntry(parTypes[i]);
         }
         IdEntry ret = KeywordToType(_return) != null ? new IdEntry() { ReflectionObject = KeywordToType(_return) } : this.GetTypeIdEntry(_return);

         UserMethod metb = type.DefineMethod(name, attr, ret, pars, parNames);

         return metb;
      }

      private Type KeywordToType(String s)
      {
         if (s.Equals("void"))
            return typeof(void);
         return null;
      }


      private UserType DefineClass(String namespace_, String name, List<String> modifiers)
      {
         TypeAttributes attr = TypeAttributes.Class;
         foreach (String s in modifiers)
         {
            attr |= (TypeAttributes)Enum.Parse(typeof(TypeAttributes), s, true);
         }
         UserType tb = new UserType(name, namespace_, attr);

         return tb;
      }

      private UserType DefineInterface(String namespace_, String name, List<String> modifiers)
      {
         TypeAttributes attr = TypeAttributes.Interface | TypeAttributes.Abstract;
         foreach (String s in modifiers)
         {
            attr |= (TypeAttributes)Enum.Parse(typeof(TypeAttributes), s, true);
         }
         UserType tb = new UserType(name, namespace_, attr);

         return tb;
      }

      private UserEnum DefineEnum(String namespace_, String name, List<String> modifiers)
      {
         TypeAttributes attr = 0;
         foreach (String s in modifiers)
         {
            attr |= (TypeAttributes)Enum.Parse(typeof(TypeAttributes), s, true);
         }
         UserEnum tb = new UserEnum(name, namespace_, attr);

         return tb;
      }

      private IdEntry GetTypeIdEntry(String name)
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
         throw new CheckerException("Type: " + name + " not found");
      }

      private bool IsAlreadyDefined(string name, string @namespace)
      {
         foreach (UserType t in userTypes)
         {
            if (t.Name.Equals(name) && t.Namespace.Equals(@namespace))
               return true;
         }
         return false;
      }
   }
}
