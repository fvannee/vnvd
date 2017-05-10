
using System;
using System.Reflection;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Vnvd
{
   /// <summary>
   /// The class to represent nodes in the abstract syntax tree (AST)
   /// </summary>
	public class TreeNode : CommonTree
	{
      /// <summary>
      /// Creates a new TreeNode object
      /// </summary>
	   public TreeNode()
		{
		}

      /// <summary>
      /// Creates a new TreeNode with the specified token
      /// </summary>
      /// <param name="t">The token to create the TreeNode with</param>
		public TreeNode(IToken t) : base(t)
		{
		}

      /// <summary>
      /// Gets or sets the type of this node, eg. if it's a method, interface.
      /// This isn't used much.
      /// </summary>
      public EntryType EntryType { get; set; }

      /// <summary>
      /// Gets or sets the corresponding IdEntry of this node. The entry is used in the symbol table and
      /// in the checker and generator to keep references to declarations of variables and call references to methods.
      /// </summary>
	   public IdEntry Entry { get; set; }

      /// <summary>
      /// Gets or sets the return type of the current node. Used for all expressions.
      /// </summary>
      public Type ReturnType { get; set; }

      /// <summary>
      /// Gets or sets the immediate value of the current node. Used for constants and optimization.
      /// </summary>
      public Object Value { get; set; }
	}
}