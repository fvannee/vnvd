using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using Vnvd.Antlr;
using Vnvd.UserDefined;

namespace Vnvd
{
   /// <summary>
   /// The class used to manually walk parts of a tree to define classes and class members
   /// </summary>
   class GeneratorManual
   {
      public const string MAINMETHOD = "Main";

      private List<TreeNode> types = new List<TreeNode>();
      private List<UserType> usertypes = new List<UserType>();
      private List<TypeBuilder> allTypes = new List<TypeBuilder>();
      private ModuleBuilder mb;
      private AssemblyBuilder ab;

      /// <summary>
      /// Creates a new GeneratorManual class
      /// </summary>
      /// <param name="mb">The modulebuilder to use as output module</param>
      /// <param name="ab">The assemblybuilder to use as output assembly</param>
      public GeneratorManual(ModuleBuilder mb, AssemblyBuilder ab)
      {
         this.mb = mb;
         this.ab = ab;
      }

      /// <summary>
      /// Gets a list with all types defined in the current assembly
      /// </summary>
      public List<TypeBuilder> AllTypes
      {
         get { return allTypes; }
      }

      /// <summary>
      /// Partially walk the tree and define all classes and interfaces encountered in the assembly.
      /// </summary>
      /// <param name="node">The tree to walk</param>
      public void WalkTypes(TreeNode node)
      {
         // manually traverse the AST so we can first define all classes before references to them are made
         foreach (TreeNode n in node.Children)
         {
            if (n.Type == VnvdTreeWalker.NAMESPACE)
            {
               foreach (TreeNode n2 in n.Children)
               {
                  if (n2.Entry != null && n2.EntryType == EntryType.Class)
                  {
                     UserType t = (UserType)n2.Entry.ReflectionObject;
                     n2.Entry.ReflectionObject = DefineClass(t.FullName, t.Attributes);
                     ((UserType) t.MakeArrayType()).Entry.ReflectionObject =
                        ((TypeBuilder) n2.Entry.ReflectionObject).MakeArrayType();
                     usertypes.Add(t);
                     types.Add(n2);
                  }
                  else if (n2.Entry != null && n2.EntryType == EntryType.Interface)
                  {
                     UserType t = (UserType)n2.Entry.ReflectionObject;
                     n2.Entry.ReflectionObject = DefineInterface(t.FullName, t.Attributes);
                     ((UserType)t.MakeArrayType()).Entry.ReflectionObject =
                        ((TypeBuilder)n2.Entry.ReflectionObject).MakeArrayType();
                     usertypes.Insert(0, t);
                     types.Insert(0, n2);
                  }
                  else if (n2.Entry != null && n2.EntryType == EntryType.Enum)
                  {
                     UserEnum t = (UserEnum)n2.Entry.ReflectionObject;
                     n2.Entry.ReflectionObject = DefineEnum(t.FullName, t.Attributes);
                     ((UserType)t.MakeArrayType()).Entry.ReflectionObject =
                        ((TypeBuilder)n2.Entry.ReflectionObject).MakeArrayType();
                     usertypes.Insert(0, t);
                     types.Insert(0, n2);
                  }
               }
            }
         }
      }

      /// <summary>
      /// To be called after WalkTypes(TreeNode). This method walks all classes and defines its methods and fields
      /// </summary>
      public void WalkTypeMembers()
      {

         // now define all methods and fields of the classes
         int interfaces = 0;
         Dictionary<TypeBuilder, UserType> hasConstructors = new Dictionary<TypeBuilder, UserType>();

         for (int i = 0; i < types.Count; i++)
         {
            TreeNode n = types[i];
            UserType customType = usertypes[i];
            TypeBuilder tb = (TypeBuilder)n.Entry.ReflectionObject;
            Type b;
            if (customType.BaseType is UserType)
               b = (Type)((UserType)customType.BaseType).Entry.ReflectionObject;
            else
               b = customType.BaseType;

            if (!tb.IsInterface)
               tb.SetParent(b);
            
            foreach (Type t in customType.GetDirectInterfaces())
            {
               tb.AddInterfaceImplementation(t);
            }

            int index = allTypes.IndexOf(tb.BaseType as TypeBuilder);
            if (index != -1 && index > allTypes.IndexOf(tb))
            {
               TypeBuilder tb2 = (TypeBuilder)tb.BaseType;
               allTypes.Remove(tb2);
               allTypes.Insert(allTypes.IndexOf(tb), tb2);
            }
            else if (tb.IsInterface && tb.GetInterfaces().Length > 0 && allTypes.IndexOf(tb.GetInterfaces()[0] as TypeBuilder) > allTypes.IndexOf(tb))
            {
               TypeBuilder tb2 = (TypeBuilder)tb.GetInterfaces()[0];
               allTypes.Remove(tb2);
               allTypes.Insert(allTypes.IndexOf(tb), tb2);
               interfaces++;
            }
            else if (tb.IsInterface)
            {
               allTypes.Remove(tb);
               allTypes.Insert(interfaces, tb);
               interfaces++;
            }

            Boolean hasConstructor = false;
            int enumCount = 0;
            foreach (TreeNode n2 in n.Children)
            {
               if (n2.Type == VnvdTreeWalker.FIELD)
               {
                  UserField uf = (UserField)n2.Entry.ReflectionObject;
                  n2.Entry.ReflectionObject = DefineField(tb, uf.Name, uf.Attributes, uf.FieldType);
               }
               else if (n2.Type == VnvdTreeWalker.CONSTRUCTOR)
               {
                  hasConstructor = true;
                  UserConstructor uf = (UserConstructor)n2.Entry.ReflectionObject;
                  n2.Entry.ReflectionObject = DefineConstructor(tb, uf.Attributes, uf.GetParameters());
               }
               else if (n2.Type == VnvdTreeWalker.METHOD)
               {
                  UserMethod uf = (UserMethod)n2.Entry.ReflectionObject;
                  n2.Entry.ReflectionObject = DefineMethod(tb, uf.Name, uf.Attributes, uf.ReturnType, uf.GetParameters());
               }
               else if (n2.Type == VnvdTreeWalker.IMETHOD)
               {
                  UserMethod uf = (UserMethod)n2.Entry.ReflectionObject;
                  n2.Entry.ReflectionObject = DefineMethod(tb, uf.Name, uf.Attributes, uf.ReturnType, uf.GetParameters());
               }
               else if (n2.Type == VnvdTreeWalker.SCONSTRUCTOR)
               {
                  //UserConstructor uf = (UserConstructor)n2.Entry.ReflectionObject;
                  n2.Entry.ReflectionObject = tb.DefineTypeInitializer();
               }
               else if (n2.Type == VnvdTreeWalker.ENUMOPTION)
               {
                  UserField uf = (UserField)n2.Entry.ReflectionObject;
                  FieldBuilder fb = tb.DefineField(uf.Name, tb, FieldAttributes.Literal | FieldAttributes.Static | FieldAttributes.Public);
                  n2.Entry.ReflectionObject = fb;
                  fb.SetConstant(enumCount);
                  enumCount++;
               }
            }
            if (tb.IsClass && !tb.IsEnum && !hasConstructor)
            {
               hasConstructors[tb] = customType;
            }
         }

         foreach (TypeBuilder t in allTypes)
         {
            if (hasConstructors.ContainsKey(t))
            {
               UserConstructor uc = (UserConstructor)hasConstructors[t].GetConstructor(new Type[] { });
               UserType baset = FindUserType(hasConstructors[t].BaseType);
               ConstructorInfo baseConstructor;
               if (baset == null)
               {
                  baseConstructor = hasConstructors[t].BaseType.GetConstructor(new Type[] { });
               }
               else
               {
                  baseConstructor = baset.GetConstructor(new Type[] { });
                  baseConstructor = (ConstructorInfo)((UserConstructor)baseConstructor).Entry.ReflectionObject;
               }
               ConstructorBuilder cb = DefineConstructor(t,
                                                         MethodAttributes.Public | MethodAttributes.HideBySig |
                                                         MethodAttributes.SpecialName | MethodAttributes.RTSpecialName,
                                                         new ParameterInfo[] {});
               ILGenerator ig = cb.GetILGenerator();
               ig.Emit(OpCodes.Call, baseConstructor);
               ig.Emit(OpCodes.Ret);
               uc.Entry.ReflectionObject = cb;
            }
         }
      }

      private UserType FindUserType(Type tb)
      {
         foreach (UserType t in usertypes)
         {
            if (t.FullName.Equals(tb.FullName))
               return t;
         }
         return null;
      }

      private ConstructorBuilder DefineConstructor(TypeBuilder type, MethodAttributes attr, ParameterInfo[] parameters)
      {
         Type[] pars = new Type[parameters.Length];
         for (int i = 0; i < parameters.Length; i++)
         {
            pars[i] = parameters[i].ParameterType;
         }
         ConstructorBuilder cb = type.DefineConstructor(attr, CallingConventions.HasThis, pars);

         for (int i = 0; i < parameters.Length; i++)
         {
            cb.DefineParameter(i + 1, parameters[i].Attributes, parameters[i].Name);
         }

         ILGenerator ig = cb.GetILGenerator();
         ig.Emit(OpCodes.Ldarg_0);

         return cb;
      }

      private FieldBuilder DefineField(TypeBuilder type, String name, FieldAttributes attr, Type _return)
      {
         return type.DefineField(name, _return, attr);
      }

      private MethodBuilder DefineMethod(TypeBuilder type, String name, MethodAttributes attr, Type _return, ParameterInfo[] parameters)
      {
         Type[] pars = new Type[parameters.Length];
         for (int i = 0; i < parameters.Length; i++)
         {
            pars[i] = parameters[i].ParameterType;
         }
         MethodBuilder metb = type.DefineMethod(name, attr, _return, pars);

         for (int i = 0; i < parameters.Length; i++)
         {
            metb.DefineParameter(i + 1, parameters[i].Attributes, parameters[i].Name);
         }

         if (name.Equals(MAINMETHOD) && _return == typeof(void) && (parameters.Length == 0 || (parameters.Length == 1 && parameters[0].ParameterType == typeof(String[]))))
         {
            ab.SetEntryPoint(metb);
         }

         return metb;
      }

      private TypeBuilder DefineClass(String name, TypeAttributes attr)
      {
         TypeBuilder tb = mb.DefineType(name, attr);
         allTypes.Add(tb);

         return tb;
      }

      private TypeBuilder DefineInterface(String name, TypeAttributes attr)
      {
         TypeBuilder tb = mb.DefineType(name, attr);
         allTypes.Add(tb);

         return tb;
      }

      private TypeBuilder DefineEnum(String name, TypeAttributes attr)
      {
         TypeBuilder enu = mb.DefineType(name, attr, typeof(Enum));
         allTypes.Add(enu);

         enu.DefineField(UserEnum.VALUE, typeof (int),
                         FieldAttributes.SpecialName | FieldAttributes.RTSpecialName | FieldAttributes.Public);
         return enu;
      }
   }
}
