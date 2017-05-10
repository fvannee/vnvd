using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Vnvd.UserDefined
{
   /// <summary>
   /// Defines an enumeration type
   /// </summary>
   class UserEnum : UserType
   {
      /// <summary>
      /// The value of the instance field of an implemented enumeration
      /// </summary>
      public const string VALUE = "value__";

      private IdEntry fieldType;
      private int optionCount;

      /// <summary>
      /// Creates a new enumeration with given name and visibility
      /// </summary>
      /// <param name="name">The name of the enum</param>
      /// <param name="namespaceName">The namespace this enum will be defined in</param>
      /// <param name="visibility">The visibility of the enum</param>
      public UserEnum(string name, string namespaceName, TypeAttributes visibility)
         : base(name, namespaceName, visibility | TypeAttributes.Sealed | TypeAttributes.Class)
      {
         this.SetBaseType(new IdEntry() {ReflectionObject = typeof (Enum)});
         fieldType = new IdEntry() { ReflectionObject = typeof(int)};

         this.DefineField(VALUE, FieldAttributes.SpecialName | FieldAttributes.RTSpecialName | FieldAttributes.Public, fieldType);
      }

      /// <summary>
      /// Defines a new option in the enumeration
      /// </summary>
      /// <param name="name">The name op the option</param>
      /// <returns>The literal field this enumeration option defined</returns>
      public UserField DefineOption(string name)
      {
         UserField f = this.DefineField(name, FieldAttributes.Literal | FieldAttributes.Static | FieldAttributes.Public, this.Entry);
         f.ConstantValue = optionCount;
         optionCount++;
         return f;
      }
   }
}
