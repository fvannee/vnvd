using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Vnvd.UserDefined
{
   /// <summary>
   /// The common interface of a user-defined method and constructor
   /// </summary>
   interface IMethodOrConstructor : _MethodBase
   {
      /// <summary>
      /// Gets the symbol table used in this method or constructor
      /// </summary>
      SymbolTable SymbolTable
      {
         get;
      }

      /// <summary>
      /// Define a local variable
      /// </summary>
      /// <param name="type">The type of the variable</param>
      /// <param name="identifier">The identifier</param>
      /// <returns>A UserLocal instance corresponding to the local variable</returns>
      UserLocal DefineLocal(IdEntry type, string identifier);
   }
}
