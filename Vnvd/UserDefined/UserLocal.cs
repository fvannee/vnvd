using System;
using System.Collections.Generic;
using System.Text;

namespace Vnvd.UserDefined
{
   /// <summary>
   /// Class to represent a user-defined local variable
   /// </summary>
   class UserLocal
   {
      private IdEntry localType;

      /// <summary>
      /// Creates a new UserLocal instance with the given type and name
      /// </summary>
      /// <param name="localType">The type of the local</param>
      /// <param name="name">The name of the local</param>
      public UserLocal(IdEntry localType, String name)
      {
         this.localType = localType;
         this.Name = name;
      }

      /// <summary>
      /// Gets the type of this local variable
      /// </summary>
      public Type LocalType
      {
         get { return (Type)localType.ReflectionObject; }
      }

      /// <summary>
      /// Gets or sets the name of this local variable
      /// </summary>
      public String Name { get; set; }
   }
}
