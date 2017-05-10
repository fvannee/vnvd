using System;
using System.Collections.Generic;
using System.Text;

namespace Vnvd
{
   /// <summary>
   /// Base for a symbol table.
   /// </summary>
   public interface ISymTab
   {
      /// <summary>
      /// Opens the scope level.
      /// </summary>
      void OpenScope();

      /// <summary>
      /// Closes the scope level
      /// </summary>
      void CloseScope();

      /// <summary>
      /// Enters an entry in the symbol table at the current level
      /// </summary>
      /// <param name="id">The identifier to access the entry</param>
      /// <param name="entry">The entry to enter</param>
      void Enter(String id, IdEntry entry);

      /// <summary>
      /// Retrieves an entry from the symbol table with the specified identifier
      /// </summary>
      /// <param name="id">The identifier to find</param>
      /// <returns>The entry corresponding to the id</returns>
      IdEntry Retrieve(String id);

      /// <summary>
      /// Gets the current scope level.
      /// </summary>
      int CurrentLevel { get; }

      /// <summary>
      /// Gets a boolean value if the symbol table currently has an open scope
      /// </summary>
      bool Open { get; }
   }
}
