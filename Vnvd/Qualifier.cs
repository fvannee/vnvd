
using System.Collections.Generic;

namespace Vnvd
{
   /// <summary>
   /// A full qualifier is an identifier for a namespace, class, method or field
   /// </summary>
   public class Qualifier : List<string>
   {
      /// <summary>
      /// The constructor for a qualifier.
      /// </summary>
      /// <param name="e">Base qualifier</param>
      public Qualifier(IEnumerable<string> e)
         : base(e)
      {

      }

      /// <summary>
      /// The constructor for a qualifier.
      /// </summary>
      public Qualifier()
      {

      }

      /// <summary>
      /// Returns whether the qualifier is an array type.
      /// </summary>
      public bool IsArray
      {
         get
         {
            return Count > 0 && this[Count - 1].EndsWith("[]");
         }
      }

      public override string ToString()
      {
         string qual = "";
         for (int i = 0; i < this.Count; i++)
         {
            if (i > 0)
            {
               qual += ".";
            }
            qual += this[i];
         }

         return qual;
      }

      /// <summary>
      /// Changes an array type qualifier to an element type qualifier.
      /// </summary>
      /// <returns>The element type qualifier</returns>
      public Qualifier ToArrayElementQual()
      {
         if (IsArray)
         {
            Qualifier ret = new Qualifier(this);
            ret[Count - 1] = ret[Count - 1].Substring(0, ret[Count - 1].Length - 2);
            return ret;
         }
         else
         {
            return this;
         }
      }

      /// <summary>
      /// Changes a qualifier to an array type qualifier.
      /// When the qualifier already is an array it adds another dimension to the array.
      /// </summary>
      /// <returns>The array type qualifier</returns>
      public Qualifier MakeArrayType()
      {
         Qualifier q = new Qualifier(this);
         q[Count - 1] += "[]";
         return q;
      }
   }
}