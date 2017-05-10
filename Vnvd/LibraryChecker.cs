
using System;
using System.Reflection;
using System.Collections.Generic;

namespace Vnvd
{
   /// <summary>
   /// Class used to check class and method references. It searches in all provided assemblies, and in the types you provide by your own
   /// </summary>
	public class LibraryChecker
	{
	   private Assembly[] assemblies;

      /// <summary>
      /// Creates a new LibraryChecker instance which can be used to search the specified assemblies
      /// </summary>
      /// <param name="assemblies">The assemblies which can be searched</param>
      public LibraryChecker(Assembly[] assemblies)
      {
         this.assemblies = assemblies;
      }
      
      /// <summary>
      /// Creates a new LibraryChecker instance which can be used to search the specified assemblies
      /// </summary>
      /// <param name="assemblyNames">An array of assembly names</param>
      public LibraryChecker(String[] assemblyNames) : this(assemblyNames, new Type[] { })
      {
      }

      /// <summary>
      /// Creates a new LibraryChecker instance which can be used to search the specified assemblies, as well as the specified types
      /// </summary>
      /// <param name="assemblyNames">An array of assembly names</param>
      /// <param name="customTypes">An array of custom types</param>
      public LibraryChecker(String[] assemblyNames, Type[] customTypes)
      {
         this.assemblies = new Assembly[assemblyNames.Length];
         for (int i = 0; i < assemblyNames.Length; i++)
         {
#pragma warning disable 618,612
            this.assemblies[i] = Assembly.LoadWithPartialName(assemblyNames[i]);
            if (this.assemblies[i] == null)
            {
               try
               {
                  this.assemblies[i] = Assembly.LoadFrom(assemblyNames[i]);
               }
               catch (Exception)
               {
                  throw new ArgumentException(assemblyNames[i] + " cannot be loaded");
               }
            }
#pragma warning restore 618,612
         }
         this.CustomTypes = customTypes;
      }

      /// <summary>
      /// Gets or sets the array of custom types which will be searched
      /// </summary>
      public Type[] CustomTypes { get; set; }

      /// <summary>
      /// Checks the library if a type is available
      /// </summary>
      /// <param name="searchType">The type to search for</param>
      /// <returns>true if the type is available, false otherwise</returns>
		public Boolean CheckType(String searchType)
		{
			return (this.GetType(searchType) != null);
		}

      /// <summary>
      /// Searches the library for the specified type
      /// </summary>
      /// <param name="searchType">The type to search for</param>
      /// <returns>A type object of the specified type, or null if the type cannot be found</returns>
		public Type GetType(String searchType)
		{
			Type type;
         foreach (Type t in CustomTypes)
         {
            if (t.FullName.Equals(searchType))
               return t;
            if (searchType.EndsWith("[]") && t.FullName.Equals(searchType.Substring(0, searchType.Length - 2)))
               return t.MakeArrayType();
         }

         foreach (Assembly asm in this.assemblies)
         {
            foreach (Module mod in asm.GetModules())
            {
               type = mod.GetType(searchType);

               if (type != null)
               {
                  return type;
               }
            }
         }
		   return null;
		}

      /// <summary>
      /// Searches the library for the specified type, taking in account the search path which is a collection of namespaces
      /// </summary>
      /// <param name="searchType">The type to search for</param>
      /// <param name="searchPath">A collection of namespaces which will be used to prefix the type to search for, to determine if the type is in one of those namespaces</param>
      /// <returns>The type object of the specified type, or null if it is not found</returns>
      public Type GetType(String searchType, ICollection<string> searchPath)
      {
         Type type;
         type = GetType(searchType);
         if (type != null)
            return type;

         foreach (String s in searchPath)
         {
            foreach (Type t in CustomTypes)
            {
               if (t.FullName.Equals(s + "." + searchType))
                  return t;
            }
            foreach (Assembly asm in this.assemblies)
            {
               foreach (Module mod in asm.GetModules())
               {
                  type = mod.GetType(s + "." + searchType);

                  if (type != null)
                  {
                     return type;
                  }
               }
            }
         }
         return null;
      }

      /// <summary>
      /// Checks if a method is available in the library
      /// </summary>
      /// <param name="searchType">The type in which to search for the method</param>
      /// <param name="searchMethod">The method name to search for</param>
      /// <param name="searchParamTypes">The parameters of the method</param>
      /// <returns>true if the method is found, false otherwise</returns>
		public Boolean CheckMethod(String searchType, String searchMethod, String[] searchParamTypes)
		{
			return (this.GetMethod(searchType, searchMethod, searchParamTypes) != null);
		}

      /// <summary>
      /// Searches the library for the specified method
      /// </summary>
      /// <param name="searchType">The type in which to search for the method</param>
      /// <param name="searchMethod">The method name to search for</param>
      /// <param name="searchParamTypes">The parameters of the method</param>
      /// <returns>The MethodInfo object of the specified method, or null if not found</returns>
		public MethodInfo GetMethod(String searchType, String searchMethod, String[] searchParamTypes)
		{
			Type type = this.GetType(searchType);

			if (type == null)
			{
				return null;
			}

			Type[] paramTypes = new Type[searchParamTypes.Length];

			for (int i = 0; i < searchParamTypes.Length; i++)
			{
				paramTypes[i] = this.GetType(searchParamTypes[i]);

				if (paramTypes[i] == null)
				{
					return null;
				}
			}

			MethodInfo method = type.GetMethod(searchMethod, BindingFlags.FlattenHierarchy, null, paramTypes, null);

			return method;
		}

      /// <summary>
      /// Searches the library for the specified method
      /// </summary>
      /// <param name="type">The type in which to search for the method</param>
      /// <param name="searchMethod">The method name to search for</param>
      /// <param name="searchParamTypes">The parameters of the method</param>
      /// <returns>The MethodInfo object of the specified method, or null if not found</returns>
      public MethodInfo GetMethod(Type type, String searchMethod, String[] searchParamTypes)
      {
         Type[] paramTypes = new Type[searchParamTypes.Length];

         for (int i = 0; i < searchParamTypes.Length; i++)
         {
            paramTypes[i] = this.GetType(searchParamTypes[i]);

            if (paramTypes[i] == null)
            {
               return null;
            }
         }

         MethodInfo method = type.GetMethod(searchMethod, BindingFlags.FlattenHierarchy, null, paramTypes, null);

         return method;
      }

      /// <summary>
      /// Checks if a method name exists in the specified types, not taking in account any method parameters.
      /// </summary>
      /// <param name="searchType">The type to search in</param>
      /// <param name="searchMethod">The method to search for</param>
      /// <returns>true if a method with the specified name is found, false otherwise</returns>
		public Boolean CheckMethodName(String searchType, String searchMethod)
		{
			Type type = this.GetType(searchType);

			if (type == null)
			{
				return false;
			}

			foreach (MethodInfo m in type.GetMethods())
			{

				if (m.Name == searchMethod)
				{
					return true;
				}
			}

			return false;
		}

      /// <summary>
      /// Checks if a field with the given name exists in the specified type
      /// </summary>
      /// <param name="searchType">The type in which to search for the field</param>
      /// <param name="searchField">The name of the field to search for</param>
      /// <returns>true if the field is found, false otherwise</returns>
		public Boolean CheckField(String searchType, String searchField)
		{
			return (this.GetField(searchType, searchField) != null);
		}

      /// <summary>
      /// Searches for a field in the given type with the specified name
      /// </summary>
      /// <param name="searchType">The type to search in</param>
      /// <param name="searchField">The field name to search for</param>
      /// <returns>The FieldInfo object of the corresponding field, or null if not found</returns>
		public FieldInfo GetField(String searchType, String searchField)
		{
			Type type = this.GetType(searchType);

			if (type == null)
			{
				return null;
			}

			FieldInfo field = type.GetField(searchField, BindingFlags.FlattenHierarchy);

			return field;
		}

      /// <summary>
      /// Searches for a field in the given type with the specified name
      /// </summary>
      /// <param name="type">The type to search in</param>
      /// <param name="searchField">The field name to search for</param>
      /// <returns>The FieldInfo object of the corresponding field, or null if not found</returns>
      public FieldInfo GetField(Type type, String searchField)
      {
         FieldInfo field = type.GetField(searchField, BindingFlags.FlattenHierarchy);
         return field;
      }

      /// <summary>
      /// Checks for the given property in the specified type
      /// </summary>
      /// <param name="searchType">The type to search in</param>
      /// <param name="searchProperty">The property to search for</param>
      /// <returns>true if the property was found, false otherwise</returns>
		public Boolean CheckProperty(String searchType, String searchProperty)
		{
			return (this.GetProperty(searchType, searchProperty) != null);
		}

      /// <summary>
      /// Searches the given type for the specified property name
      /// </summary>
      /// <param name="searchType">The type to search in</param>
      /// <param name="searchProperty">The property name to search for</param>
      /// <returns>The PropertyInfo of the corresponding property, or null if not found</returns>
		public PropertyInfo GetProperty(String searchType, String searchProperty)
		{
			Type type = this.GetType(searchType);

			if (type == null)
			{
				return null;
			}

			PropertyInfo property = type.GetProperty(searchProperty);

			return property;
		}

      /// <summary>
      /// Searches the given type for the specified property name
      /// </summary>
      /// <param name="type">The type to search in</param>
      /// <param name="searchProperty">The property name to search for</param>
      /// <returns>The PropertyInfo of the corresponding property, or null if not found</returns>
      public PropertyInfo GetProperty(Type type, String searchProperty)
      {
         PropertyInfo property = type.GetProperty(searchProperty);
         return property;
      }

      /// <summary>
      /// Checks if the given constructor is available on the specified type
      /// </summary>
      /// <param name="searchType">The type to search in</param>
      /// <param name="searchParamTypes">An array of types which define the parameter types to search for</param>
      /// <returns>true if the constructor is found, false otherwise</returns>
		public Boolean CheckConstructor(String searchType, String[] searchParamTypes)
		{
			return (this.GetConstructor(searchType, searchParamTypes) != null);
		}

      /// <summary>
      /// Searches for the given constructor in the specified type
      /// </summary>
      /// <param name="searchType">The type to search in</param>
      /// <param name="searchParamTypes">An array of types which define the parameter types to search for</param>
      /// <returns>A ConstructorInfo object corresponding to the constructor, or null if not found</returns>
		public ConstructorInfo GetConstructor(String searchType, String[] searchParamTypes)
		{
			Type type = this.GetType(searchType);

			if (type == null)
			{
				return null;
			}

			Type[] paramTypes = new Type[searchParamTypes.Length];

			for (int i = 0; i < searchParamTypes.Length; i++)
			{
				paramTypes[i] = this.GetType(searchParamTypes[i]);

				if (paramTypes[i] == null)
				{
					return null;
				}
			}

			ConstructorInfo constructor = type.GetConstructor(paramTypes);

			return constructor;
		}

      /// <summary>
      /// Searches for the given constructor in the specified type
      /// </summary>
      /// <param name="type">The type to search in</param>
      /// <param name="searchParamTypes">An array of types which define the parameter types to search for</param>
      /// <returns>A ConstructorInfo object corresponding to the constructor, or null if not found</returns>
      public ConstructorInfo GetConstructor(Type type, String[] searchParamTypes)
      {
         Type[] paramTypes = new Type[searchParamTypes.Length];

         for (int i = 0; i < searchParamTypes.Length; i++)
         {
            paramTypes[i] = this.GetType(searchParamTypes[i]);

            if (paramTypes[i] == null)
            {
               return null;
            }
         }

         ConstructorInfo constructor = type.GetConstructor(paramTypes);

         return constructor;
      }

      /// <summary>
      /// Converts an array of IdEntry objects to an array of objects of the specified generic type.
      /// The value of the elements of the returned array is that of the ReflectionObject property of each IdEntry casted to T
      /// </summary>
      /// <typeparam name="T">The type to cast the ReflectionObject objects to</typeparam>
      /// <param name="entries">The entries to convert</param>
      /// <returns>An array with elements of type T</returns>
      public static T[] ToArray<T>(IdEntry[] entries)
      {
         T[] ret = new T[entries.Length];
         for (int i = 0; i < entries.Length; i++)
         {
            ret[i] = (T)entries[i].ReflectionObject;
         }
         return ret;
      }
	}
}