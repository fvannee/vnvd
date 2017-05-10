using System;
using System.Collections.Generic;
using System.Text;

namespace Vnvd
{
   /// <summary>
   /// The enumeration of types of an entry
   /// </summary>
   public enum EntryType
   {
      /// <summary>
      /// Defines a namespace
      /// </summary>
      Namespace,

      /// <summary>
      /// Defines a class
      /// </summary>
      Class,

      /// <summary>
      /// Defines an interface
      /// </summary>
      Interface,

      /// <summary>
      /// Defines a method
      /// </summary>
      Method,
      
      /// <summary>
      /// Defines a constructor
      /// </summary>
      Constructor,

      /// <summary>
      /// Defines a variable
      /// </summary>
      Variable,

      /// <summary>
      /// Defines or references a constant
      /// </summary>
      Constant,

      /// <summary>
      /// References a static variable
      /// </summary>
      StaticVar,

      /// <summary>
      /// References an array
      /// </summary>
      Array,

      /// <summary>
      /// Defines or references a field
      /// </summary>
      Field,

      /// <summary>
      /// References an event
      /// </summary>
      Event,

      /// <summary>
      /// Defines an enumeration
      /// </summary>
      Enum
   }
}
