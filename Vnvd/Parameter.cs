
using System.Collections.Generic;

namespace Vnvd
{
   /// <summary>
   /// This class represents a parameter.
   /// A combination of a type (Qualifier) and an identifier (string).
   /// </summary>
   public class Parameter : Pair<Qualifier, string>
   {
      /// <summary>
      /// Constructor for a parameter.
      /// </summary>
      /// <param name="qualifier">The full qualifier of the type</param>
      /// <param name="str">The identifier of the parameter</param>
      public Parameter(Qualifier qualifier, string str)
         : base(qualifier, str)
      {
      }
   }
}