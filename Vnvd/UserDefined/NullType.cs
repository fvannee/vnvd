using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Vnvd.UserDefined
{
   /// <summary>
   /// The class to represent a null value type
   /// </summary>
   class NullType : UserType
   {
      private const string NAME = "~null~";

      private NullType()
         : base(NAME, NAME, TypeAttributes.Public)
      {
         
      }

      private static NullType _default = new NullType();
      private static IdEntry _defaultEntry = new IdEntry() { ReflectionObject = _default };
      
      /// <summary>
      /// Gets the default NullType instance
      /// </summary>
      public static NullType Default
      {
         get { return _default; }
      }

      /// <summary>
      /// Gets the default IdEntry corresponding to the default NullType instance
      /// </summary>
      public static IdEntry DefaultEntry
      {
         get { return _defaultEntry; }
      }

      protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
      {
         return null;
      }

      public override bool IsAssignableFrom(Type c)
      {
         return false;
      }

      public override bool IsSubclassOf(Type c)
      {
         return false;
      }

      public override Type BaseType { get { return null; } }
   }
}
