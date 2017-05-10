
using System;
using System.Reflection;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Vnvd
{
   /// <summary>
   /// The adapter used by ANTLR to create nodes of our custom node type. This adapter creates node of type TreeNode
   /// </summary>
	public class TreeNodeAdaptor : CommonTreeAdaptor
   {
      /// <summary>
      /// Creates a new node of type TreeNode
      /// </summary>
      /// <param name="payload">The token with which to construct the TreeNode</param>
      /// <returns>The TreeNode object</returns>
      public override object Create(IToken payload)
		{
			return new TreeNode(payload);
		}

      /// <summary>
      /// Duplicates the given node (used when rewriting trees)
      /// </summary>
      /// <param name="t">The node to duplicate</param>
      /// <returns>The duplicated node</returns>
      public override object DupNode(object t)
      {
         return new TreeNode(((TreeNode) t).Token);
      }
	}
}