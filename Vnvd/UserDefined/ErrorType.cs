using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Vnvd.UserDefined
{
   /// <summary>
   /// The class to represent an error state. This type is used when there are errors detected in user's code.
   /// </summary>
   class ErrorType : UserType
   {
      private const string NAME = "~error~";

      /// <summary>
      /// Constructs a new ErrorType instance
      /// </summary>
      private ErrorType()
         : base(NAME, NAME, TypeAttributes.Public)
      {
         
      }

      private static ErrorType _default = new ErrorType();
      private static IdEntry _defaultEntry = new IdEntry() { ReflectionObject = _default };
      
      /// <summary>
      /// Gets the default instance of ErrorType
      /// </summary>
      public static ErrorType Default
      {
         get { return _default; }
      }

      /// <summary>
      /// Gets the default instance of ErrorType as an IdEntry. return.ReflectionObject is the ErrorType instance
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
