using System;
using System.Collections.Generic;

namespace Vnvd
{
   /// <summary>
   /// The basic implementation of a symbol table
   /// </summary>
	public class SymbolTable : ISymTab
	{
		private Dictionary<String, Stack<IdEntry>> entries;
		private Stack<List<String>> cache;

		/// <summary>
		/// Constructs a SymbolTable object
		/// </summary>
		public SymbolTable()
		{
			this.entries = new Dictionary<String, Stack<IdEntry>>();
			this.cache = new Stack<List<String>>();
		}

		/// <summary>
		/// Opens a new scope.
		/// </summary>
		public void OpenScope()
		{
			this.cache.Push(new List<String>());
		}

	   /// <summary>
		/// Closes the current scope. All identifiers in the current scope will be removed from the SymbolTable.
		/// </summary>
		public void CloseScope()
		{
			List<String> toKill = this.cache.Pop();

			foreach (String dood in toKill)
			{
				this.entries[dood].Pop();
			}
		}

		/// <summary>
		/// Gets the current scope level.
		/// </summary>
		public int CurrentLevel
		{
			get
			{
				return this.cache.Count;
			}
		}

      /// <summary>
      /// Gets a boolean value if the current symbol table is open
      /// </summary>
		public bool Open
		{
			get
			{
				return (this.cache.Count != 0);
			}
		}

		/// <summary>
		/// Enters an id together with an entry into this SymbolTable using the
		/// current scope level. The entry's level is set to this.Level
		/// </summary>
		/// <param name="id">The identifier to enter</param>
		/// <param name="entry">The entry to enter</param>
		public void Enter(String id, IdEntry entry)
		{

			entry.Level = this.CurrentLevel;

			if (this.cache.Peek().Contains(id))
			{
				throw new SymbolTableException("Variable already declared for current scope: " + id);
			}

			if (!entries.ContainsKey(id))
			{
				entries[id] = new Stack<IdEntry>();
			}
			cache.Peek().Add(id);
			entries[id].Push(entry);
		}

		/// <summary>
		/// Get the IdEntry corresponding with id whose level is the highest. In other
		/// words, the method returns the IdEntry that is defined last.
		/// </summary>
		/// <param name="id">The identifier to retrieve</param>
		/// <returns>The corresponding entry, or null if not found</returns>
		public IdEntry Retrieve(String id)
		{
		   return this.entries.ContainsKey(id) && this.entries[id].Count > 0 ? this.entries[id].Peek() : null;
		}
	}

	/// <summary>
	/// Exception class to signal problems with the SymbolTable
	/// </summary>
	public class SymbolTableException : Exception
	{
      /// <summary>
      /// Constructs a SymbolTableException with the given message
      /// </summary>
      /// <param name="msg">The error message</param>
		public SymbolTableException(String msg) : base(msg)
		{
		}
	}
}