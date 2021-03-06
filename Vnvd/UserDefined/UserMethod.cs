﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Vnvd.UserDefined
{
   /// <summary>
   /// Class to represent a user-defined method
   /// </summary>
   class UserMethod : MethodInfo, IMethodOrConstructor
   {
      private string name;
      private MethodAttributes attributes;
      private IdEntry declaringType, returnType;
      private ParameterInfo[] parameters;
      private Type[] parameterTypes;
      private SymbolTable symbolTable;

      /// <summary>
      /// Creates a new UserMethod with the given parameters
      /// </summary>
      /// <param name="declaringType">The type which declares this method</param>
      /// <param name="name">The name of the method</param>
      /// <param name="returnType">The return type of the method</param>
      /// <param name="parameters">The parameters which have to be passed to the method</param>
      /// <param name="parNames">The names of the parameters</param>
      /// <param name="attributes">The attributes of the method</param>
      public UserMethod(IdEntry declaringType, String name, IdEntry returnType, IdEntry[] parameters, String[] parNames, MethodAttributes attributes)
      {
         this.declaringType = declaringType;
         this.name = name;
         this.returnType = returnType;
         this.attributes = attributes;
         this.parameters = new ParameterInfo[parameters.Length];
         this.parameterTypes = new Type[parameters.Length];
         this.symbolTable = new SymbolTable();
         this.symbolTable.OpenScope();

         bool isstatic = (attributes & MethodAttributes.Static) != 0;
         for (int i = 0; i < parameters.Length; i++ )
         {
            this.parameters[i] = new UserParameter(parameters[i], parNames[i], isstatic ? i : i + 1);
            this.parameterTypes[i] = this.parameters[i].ParameterType;
            IdEntry id = new IdEntry();
            id.ReflectionObject = this.parameters[i];
            this.symbolTable.Enter(parNames[i], id);
         }
      }

      /// <summary>
      /// When overridden in a derived class, returns an array containing all the custom attributes.
      /// </summary>
      /// <returns>
      /// An array that contains all the custom attributes, or an array with zero elements if no attributes are defined.
      /// </returns>
      /// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
      /// <exception cref="T:System.InvalidOperationException">This member belongs to a type that is loaded into the reflection-only context. See How to: Load Assemblies into the Reflection-Only Context.</exception>
      /// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
      public override object[] GetCustomAttributes(bool inherit)
      {
         throw new System.InvalidOperationException();
      }

      /// <summary>
      /// When overridden in a derived class, indicates whether one or more instance of <paramref name="attributeType" /> is applied to this member.
      /// </summary>
      /// <returns>
      /// true if one or more instance of <paramref name="attributeType" /> is applied to this member; otherwise false.
      /// </returns>
      /// <param name="attributeType">The Type object to which the custom attributes are applied. </param>
      /// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
      public override bool IsDefined(Type attributeType, bool inherit)
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// When overridden in a derived class, gets the parameters of the specified method or constructor.
      /// </summary>
      /// <returns>
      /// An array of type ParameterInfo containing information that matches the signature of the method (or constructor) reflected by this MethodBase instance.
      /// </returns>
      public override ParameterInfo[] GetParameters()
      {
         return parameters;
      }

      /// <summary>
      /// When overridden in a derived class, returns the <see cref="T:System.Reflection.MethodImplAttributes" /> flags.
      /// </summary>
      /// <returns>
      /// The MethodImplAttributes flags.
      /// </returns>
      public override MethodImplAttributes GetMethodImplementationFlags()
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// When overridden in a derived class, invokes the reflected method or constructor with the given parameters.
      /// </summary>
      /// <returns>
      /// An Object containing the return value of the invoked method, or null in the case of a constructor, or null if the method's return type is void. Before calling the method or constructor, Invoke checks to see if the user has access permission and verify that the parameters are valid.
      /// </returns>
      /// <param name="obj">The object on which to invoke the method or constructor. If a method is static, this argument is ignored. If a constructor is static, this argument must be null or an instance of the class that defines the constructor.</param>
      /// <param name="invokeAttr">A bitmask that is a combination of 0 or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. If <paramref name="binder" /> is null, this parameter is assigned the value <see cref="F:System.Reflection.BindingFlags.Default" />; thus, whatever you pass in is ignored. </param>
      /// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects via reflection. If <paramref name="binder" /> is null, the default binder is used. </param>
      /// <param name="parameters">An argument list for the invoked method or constructor. This is an array of objects with the same number, order, and type as the parameters of the method or constructor to be invoked. If there are no parameters, this should be null.If the method or constructor represented by this instance takes a ByRef parameter, there is no special attribute required for that parameter in order to invoke the method or constructor using this function. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is null. For value-type elements, this value is 0, 0.0, or false, depending on the specific element type. </param>
      /// <param name="culture">An instance of CultureInfo used to govern the coercion of types. If this is null, the CultureInfo for the current thread is used. (This is necessary to convert a String that represents 1000 to a Double value, for example, since 1000 is represented differently by different cultures.) </param>
      /// <exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the method is not static.-or- The method is not declared or inherited by the class of <paramref name="obj" />. -or-A static constructor is invoked, and <paramref name="obj" /> is neither null nor an instance of the class that declared the constructor.</exception>
      /// <exception cref="T:System.ArgumentException">The type of the <paramref name="parameters" /> parameter does not match the signature of the method or constructor reflected by this instance. </exception>
      /// <exception cref="T:System.Reflection.TargetParameterCountException">The <paramref name="parameters" /> array does not have the correct number of arguments. </exception>
      /// <exception cref="T:System.Reflection.TargetInvocationException">The invoked method or constructor throws an exception. </exception>
      /// <exception cref="T:System.MethodAccessException">The caller does not have permission to execute the constructor. </exception>
      /// <exception cref="T:System.InvalidOperationException">The type that declares the method is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns true for the declaring type.</exception>
      public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
      {
         throw new System.InvalidOperationException();
      }

      /// <summary>
      /// When overridden in a derived class, returns the MethodInfo object for the method on the direct or indirect base class in which the method represented by this instance was first declared.
      /// </summary>
      /// <returns>
      /// A MethodInfo object for the first implementation of this method.
      /// </returns>
      public override MethodInfo GetBaseDefinition()
      {
         MethodInfo firstDeclared = this;
         Type baseType = ((Type)this.declaringType.ReflectionObject).BaseType;
         while (baseType != null)
         {
            MethodInfo temp = baseType.GetMethod(name, parameterTypes);
            if (temp != null)
            {
               firstDeclared = temp;
            }
            baseType = baseType.BaseType;
         }
         return firstDeclared;
      }

      /// <summary>
      /// Gets the custom attributes for the return type.
      /// </summary>
      /// <returns>
      /// An ICustomAttributeProvider object representing the custom attributes for the return type.
      /// </returns>
      public override ICustomAttributeProvider ReturnTypeCustomAttributes
      {
         get { throw new System.NotImplementedException(); }
      }

      /// <summary>
      /// Gets the name of the current member.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.String" /> containing the name of this member.
      /// </returns>
      public override string Name
      {
         get { return name; }
      }

      /// <summary>
      /// Gets the class that declares this member.
      /// </summary>
      /// <returns>
      /// The Type object for the class that declares this member.
      /// </returns>
      public override Type DeclaringType
      {
         get { return (Type)declaringType.ReflectionObject; }
      }

      /// <summary>
      /// Gets the class object that was used to obtain this instance of MemberInfo.
      /// </summary>
      /// <returns>
      /// The Type object through which this MemberInfo object was obtained.
      /// </returns>
      public override Type ReflectedType
      {
         get { throw new System.NotImplementedException(); }
      }

      /// <summary>
      /// Gets a handle to the internal metadata representation of a method.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.RuntimeMethodHandle" /> object.
      /// </returns>
      public override RuntimeMethodHandle MethodHandle
      {
         get { throw new System.NotImplementedException(); }
      }

      /// <summary>
      /// Gets the attributes associated with this method.
      /// </summary>
      /// <returns>
      /// One of the <see cref="T:System.Reflection.MethodAttributes" /> values.
      /// </returns>
      public override MethodAttributes Attributes
      {
         get { return attributes; }
      }

      /// <summary>
      /// When overridden in a derived class, returns an array of custom attributes identified by <see cref="T:System.Type" />.
      /// </summary>
      /// <returns>
      /// An array of custom attributes applied to this member, or an array with zero (0) elements if no attributes have been applied.
      /// </returns>
      /// <param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned. </param>
      /// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
      /// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded. </exception>
      /// <exception cref="T:System.ArgumentNullException">If <paramref name="attributeType" /> is null.</exception>
      /// <exception cref="T:System.InvalidOperationException">This member belongs to a type that is loaded into the reflection-only context. See How to: Load Assemblies into the Reflection-Only Context.</exception>
      public override object[] GetCustomAttributes(Type attributeType, bool inherit)
      {
         throw new System.NotImplementedException();
      }

      ///<summary>
      ///Gets the return type of this method.
      ///</summary>
      ///
      ///<returns>
      ///The return type of this method.
      ///</returns>
      ///
      public override Type ReturnType
      {
         get
         {
            return (Type)returnType.ReflectionObject;
         }
      }

      /// <summary>
      /// Gets the symbol table of this method
      /// </summary>
      public SymbolTable SymbolTable { get { return symbolTable;  } }

      /// <summary>
      /// Defines a local variable in this method
      /// </summary>
      /// <param name="type">The type of this local variable</param>
      /// <param name="identifier">The identifier of the local variable</param>
      /// <returns></returns>
      public UserLocal DefineLocal(IdEntry type, string identifier)
      {
         UserLocal local = new UserLocal(type, identifier);
         return local;
      }

      /// <summary>
      /// Gets or sets the IdEntry where this method is defined in the AST
      /// </summary>
      public IdEntry Entry { get; set; }
   }
}
