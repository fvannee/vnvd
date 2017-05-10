using System;
using System.Collections.Generic;
using System.Reflection;

namespace Vnvd
{
   /// <summary>
   /// The class which is used in the SymbolTable and in nearly all parts of the tree.
   /// </summary>
	public class IdEntry
	{
      /// <summary>
      /// Creates a new IdEntry object
      /// </summary>
	   public IdEntry()
		{
		   Level = -1;
		}

      /// <summary>
      /// Gets or sets the level on which this IdEntry is stored in the symbol table.
      /// </summary>
	   public int Level { get; set; }

      /// <summary>
      /// Gets or sets the reflection object associated with this entry.
      /// Although the type is Object, it is usually a reference to a method or variable declaration - MethodInfo, Type, things like that.
      /// </summary>
      public Object ReflectionObject { get; set; }

      /// <summary>
      /// Gets or sets the tree node associated with this IdEntry
      /// </summary>
	   public TreeNode Node { get; set; }

      public override bool Equals(object obj)
      {
         if (obj is IdEntry)
         {
            IdEntry o = (IdEntry) obj;
            return o.ReflectionObject == this.ReflectionObject && o.Level == this.Level && o.Node == this.Node;
         }
         return false;
      }

      /// <summary>
      /// Serves as a hash function for a particular type. 
      /// </summary>
      /// <returns>
      /// A hash code for the current <see cref="T:System.Object"/>.
      /// </returns>
      /// <filterpriority>2</filterpriority>
      public override int GetHashCode()
      {
         unchecked
         {
            int result = Level;
            result = (result*397) ^ (ReflectionObject != null ? ReflectionObject.GetHashCode() : 0);
            result = (result*397) ^ (Node != null ? Node.GetHashCode() : 0);
            return result;
         }
      }
	}
}