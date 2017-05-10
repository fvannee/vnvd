using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Vnvd.UserDefined
{
   /// <summary>
   /// Class to represent a user-defined type
   /// </summary>
   class UserType : Type
   {
      private String name, namespaceName;
      private List<MethodInfo> methods;
      private List<ConstructorInfo> constructors;
      private List<FieldInfo> fields;
      private List<IdEntry> interfaces;
      private IdEntry baseType;
      private TypeAttributes attributes;
      private IdEntry elementType;
      private Type arrayType;
      private UserConstructor staticConstructor;

      /// <summary>
      /// Creates a new type with given name, namespace and attributes
      /// </summary>
      /// <param name="name">The name of the type</param>
      /// <param name="namespaceName">The namespace in which the type is declared</param>
      /// <param name="attributes">The attributes of the type</param>
      public UserType(String name, String namespaceName, TypeAttributes attributes)
      {
         this.name = name;
         this.namespaceName = namespaceName;
         this.attributes = attributes;
         this.methods = new List<MethodInfo>();
         this.fields = new List<FieldInfo>();
         this.interfaces = new List<IdEntry>();
         this.constructors = new List<ConstructorInfo>();
      }

      /// <summary>
      /// Creates a new type with given name, namespace, attributes and elementType. Used for arrays
      /// </summary>
      /// <param name="name">The name of the type</param>
      /// <param name="namespaceName">The namespace in which the type is declared</param>
      /// <param name="attributes">The attributes of the type</param>
      /// <param name="elementType">The element type of the array</param>
      protected UserType(String name, String namespaceName, TypeAttributes attributes, IdEntry elementType) : this(name, namespaceName, attributes)
      {
         this.elementType = elementType;
         this.Entry = new IdEntry();
         this.Entry.ReflectionObject = this;
         this.baseType = new IdEntry();
         this.baseType.ReflectionObject = typeof (Array);
      }

      /// <summary>
      /// Retrieves a method on this type defined by some interface this type implements
      /// </summary>
      /// <param name="name">The name of the method</param>
      /// <param name="types">The parameters the method to search for takes</param>
      /// <returns>A MethodInfo instance with the method, or null if not found</returns>
      public MethodInfo GetInterfaceMethod(string name, Type[] types)
      {
         foreach (Type t in GetInterfaces())
         {
            MethodInfo ret = t.GetMethod(name, types);
            if (ret != null)
               return ret;
         }
         return null;
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
      /// When overridden in a derived class, searches for the constructors defined for the current <see cref="T:System.Type" />, using the specified BindingFlags.
      /// </summary>
      /// <returns>
      /// An array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing all constructors defined for the current <see cref="T:System.Type" /> that match the specified binding constraints, including the type initializer if it is defined. Returns an empty array of type <see cref="T:System.Reflection.ConstructorInfo" /> if no constructors are defined for the current <see cref="T:System.Type" />, if none of the defined constructors match the binding constraints, or if the current <see cref="T:System.Type" /> represents a type parameter in the definition of a generic type or generic method.
      /// </returns>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><filterpriority>2</filterpriority>
      public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
      {
         return constructors.ToArray();
      }

      /// <summary>
      /// When overridden in a derived class, searches for the specified interface, specifying whether to do a case-insensitive search for the interface name.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.Type" /> object representing the interface with the specified name, implemented or inherited by the current <see cref="T:System.Type" />, if found; otherwise, null.
      /// </returns>
      /// <param name="name">The <see cref="T:System.String" /> containing the name of the interface to get. For generic interfaces, this is the mangled name.</param>
      /// <param name="ignoreCase">true to ignore the case of that part of <paramref name="name" /> that specifies the simple interface name (the part that specifies the namespace must be correctly cased).-or- false to perform a case-sensitive search for all parts of <paramref name="name" />. </param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
      /// <exception cref="T:System.Reflection.AmbiguousMatchException">The current <see cref="T:System.Type" /> represents a type that implements the same generic interface with different type arguments. </exception><filterpriority>2</filterpriority>
      public override Type GetInterface(string name, bool ignoreCase)
      {
         Type ret = null;
         List<IdEntry>.Enumerator en = interfaces.GetEnumerator();
         bool found = false;
         StringComparison compare = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
         while (en.MoveNext() && !found)
         {
            ret = (Type)en.Current.ReflectionObject;
            found = ret.Name.Equals(name, compare);
         }
         return found ? ret : (this.baseType != null ? BaseType.GetInterface(name, ignoreCase) : null);
      }

      /// <summary>
      /// When overridden in a derived class, gets all the interfaces implemented or inherited by the current <see cref="T:System.Type" />.
      /// </summary>
      /// <returns>
      /// An array of <see cref="T:System.Type" /> objects representing all the interfaces implemented or inherited by the current <see cref="T:System.Type" />.-or- An empty array of type <see cref="T:System.Type" />, if no interfaces are implemented or inherited by the current <see cref="T:System.Type" />.
      /// </returns>
      /// <exception cref="T:System.Reflection.TargetInvocationException">A static initializer is invoked and throws an exception. </exception><filterpriority>2</filterpriority>
      public override Type[] GetInterfaces()
      {
         List<Type> ret = new List<Type>(LibraryChecker.ToArray<Type>(interfaces.ToArray()));
         if (baseType != null)
            ret.AddRange(BaseType.GetInterfaces());
         return ret.ToArray();
      }

      /// <summary>
      /// When overridden in a derived class, gets all the interfaces implemented or inherited by the current <see cref="T:System.Type" />.
      /// </summary>
      /// <returns>
      /// An array of <see cref="T:System.Type" /> objects representing all the interfaces implemented or inherited by the current <see cref="T:System.Type" />.-or- An empty array of type <see cref="T:System.Type" />, if no interfaces are implemented or inherited by the current <see cref="T:System.Type" />.
      /// </returns>
      /// <exception cref="T:System.Reflection.TargetInvocationException">A static initializer is invoked and throws an exception. </exception><filterpriority>2</filterpriority>
      public Type[] GetDirectInterfaces()
      {
         return LibraryChecker.ToArray<Type>(interfaces.ToArray());
      }

      /// <summary>
      /// When overridden in a derived class, returns the <see cref="T:System.Reflection.EventInfo" /> object representing the specified event, using the specified binding constraints.
      /// </summary>
      /// <returns>
      /// The <see cref="T:System.Reflection.EventInfo" /> object representing the specified event which is declared or inherited by the current <see cref="T:System.Type" />, if found; otherwise, null.
      /// </returns>
      /// <param name="name">The <see cref="T:System.String" /> containing the name of an event which is declared or inherited by the current <see cref="T:System.Type" />. </param>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><filterpriority>2</filterpriority>
      public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
      {
         if ((bindingAttr & BindingFlags.FlattenHierarchy) != 0 && BaseType != null)
         {
            return BaseType.GetEvent(name, bindingAttr);
         }
         else
         {
            return null;
         }
      }

      /// <summary>
      /// When overridden in a derived class, searches for events that are declared or inherited by the current <see cref="T:System.Type" />, using the specified binding constraints.
      /// </summary>
      /// <returns>
      /// An array of <see cref="T:System.Reflection.EventInfo" /> objects representing all events which are declared or inherited by the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.EventInfo" />, if the current <see cref="T:System.Type" /> does not have events, or if none of the events match the binding constraints.
      /// </returns>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><filterpriority>2</filterpriority>
      public override EventInfo[] GetEvents(BindingFlags bindingAttr)
      {
         if ((bindingAttr & BindingFlags.FlattenHierarchy) != 0 && BaseType != null)
         {
            return BaseType.GetEvents(bindingAttr);
         }
         else
         {
            return new EventInfo[] { };
         }
      }

      /// <summary>
      /// When overridden in a derived class, searches for the types nested in the current <see cref="T:System.Type" />, using the specified binding constraints.
      /// </summary>
      /// <returns>
      /// An array of <see cref="T:System.Type" /> objects representing all the types nested in the current <see cref="T:System.Type" /> that match the specified binding constraints (the search is not recursive), or an empty array of type <see cref="T:System.Type" />, if no nested types are found that match the binding constraints.
      /// </returns>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><filterpriority>2</filterpriority>
      public override Type[] GetNestedTypes(BindingFlags bindingAttr)
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// When overridden in a derived class, searches for the specified nested type, using the specified binding constraints.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.Type" /> object representing the nested type that matches the specified requirements, if found; otherwise, null.
      /// </returns>
      /// <param name="name">The string containing the name of the nested type to get. </param>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><filterpriority>2</filterpriority>
      public override Type GetNestedType(string name, BindingFlags bindingAttr)
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// When overridden in a derived class, returns the <see cref="T:System.Type" /> of the object encompassed or referred to by the current array, pointer or reference type.
      /// </summary>
      /// <returns>
      /// The <see cref="T:System.Type" /> of the object encompassed or referred to by the current array, pointer, or reference type, or null if the current <see cref="T:System.Type" /> is not an array or a pointer, or is not passed by reference, or represents a generic type or a type parameter in the definition of a generic type or generic method.
      /// </returns>
      /// <filterpriority>2</filterpriority>
      public override Type GetElementType()
      {
         return (Type)elementType.ReflectionObject;
      }

      /// <summary>
      /// When overridden in a derived class, implements the <see cref="P:System.Type.HasElementType" /> property and determines whether the current <see cref="T:System.Type" /> encompasses or refers to another type; that is, whether the current <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference.
      /// </summary>
      /// <returns>
      /// true if the <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference; otherwise, false.
      /// </returns>
      protected override bool HasElementTypeImpl()
      {
         return elementType != null;
      }

      /// <summary>
      /// When overridden in a derived class, searches for the specified property whose parameters match the specified argument types and modifiers, using the specified binding constraints.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.Reflection.PropertyInfo" /> object representing the property that matches the specified requirements, if found; otherwise, null.
      /// </returns>
      /// <param name="name">The <see cref="T:System.String" /> containing the name of the property to get. </param>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
      /// <param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded member, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param>
      /// <param name="returnType">The return type of the property. </param>
      /// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed. </param>
      /// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
      /// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one property is found with the specified name and matching the specified binding constraints. </exception>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.-or- <paramref name="types" /> is null.-or- One of the elements in <paramref name="types" /> is null. </exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="types" /> is multidimensional.-or- <paramref name="modifiers" /> is multidimensional.-or- <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length. </exception>
      protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// When overridden in a derived class, searches for the properties of the current <see cref="T:System.Type" />, using the specified binding constraints.
      /// </summary>
      /// <returns>
      /// An array of <see cref="T:System.Reflection.PropertyInfo" /> objects representing all properties of the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.PropertyInfo" />, if the current <see cref="T:System.Type" /> does not have properties, or if none of the properties match the binding constraints.
      /// </returns>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><filterpriority>2</filterpriority>
      public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// When overridden in a derived class, searches for the specified method whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.Reflection.MethodInfo" /> object representing the method that matches the specified requirements, if found; otherwise, null.
      /// </returns>
      /// <param name="name">The <see cref="T:System.String" /> containing the name of the method to get. </param>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
      /// <param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param>
      /// <param name="callConvention">The <see cref="T:System.Reflection.CallingConventions" /> object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and what process cleans up the stack. </param>
      /// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a method that takes no parameters.-or- null. If <paramref name="types" /> is null, arguments are not matched. </param>
      /// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
      /// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method is found with the specified name and matching the specified binding constraints. </exception>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="types" /> is multidimensional.-or- <paramref name="modifiers" /> is multidimensional.-or- <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length. </exception>
      protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
      {
         binder = CustomBinder.Default;
         List<MethodInfo> met = new List<MethodInfo>();
         foreach (MethodInfo m in this.GetMethods(bindingAttr))
         {
            if (m.Name.Equals(name))
               met.Add(m);
         }
         if (this.IsInterface)
         {
            foreach (Type t in this.GetInterfaces())
            {
               foreach (MethodInfo m in t.GetMethods(bindingAttr))
               {
                  if (m.Name.Equals(name))
                     met.Add(m);
               }
            }
         }

         if (met.Count == 0)
            return null;

         return (MethodInfo)binder.SelectMethod(bindingAttr, met.ToArray(), types, modifiers);
      }

      /// <summary>
      /// When overridden in a derived class, searches for the methods defined for the current <see cref="T:System.Type" />, using the specified binding constraints.
      /// </summary>
      /// <returns>
      /// An array of <see cref="T:System.Reflection.MethodInfo" /> objects representing all methods defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.MethodInfo" />, if no methods are defined for the current <see cref="T:System.Type" />, or if none of the defined methods match the binding constraints.
      /// </returns>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><filterpriority>2</filterpriority>
      public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
      {
         if ((bindingAttr & BindingFlags.FlattenHierarchy) != 0 && BaseType != null)
         {
            List<MethodInfo> ret = new List<MethodInfo>(methods);
            ret.AddRange(BaseType.GetMethods(bindingAttr));
            return ret.ToArray();
         }
         else
         {
            return methods.ToArray();
         }
      }

      /// <summary>
      /// Searches for the specified field, using the specified binding constraints.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.Reflection.FieldInfo" /> object representing the field that matches the specified requirements, if found; otherwise, null.
      /// </returns>
      /// <param name="name">The <see cref="T:System.String" /> containing the name of the data field to get. </param>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><filterpriority>2</filterpriority>
      public override FieldInfo GetField(string name, BindingFlags bindingAttr)
      {
         FieldInfo ret = null;
         List<FieldInfo>.Enumerator en = fields.GetEnumerator();
         bool found = false;
         while (en.MoveNext() && !found)
         {
            ret = en.Current;
            found = en.Current.Name.Equals(name);
         }
         return found ? ret : (this.BaseType != null ? BaseType.GetField(name, bindingAttr) : null);
      }

      /// <summary>
      /// When overridden in a derived class, searches for the fields defined for the current <see cref="T:System.Type" />, using the specified binding constraints.
      /// </summary>
      /// <returns>
      /// An array of <see cref="T:System.Reflection.FieldInfo" /> objects representing all fields defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.FieldInfo" />, if no fields are defined for the current <see cref="T:System.Type" />, or if none of the defined fields match the binding constraints.
      /// </returns>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><filterpriority>2</filterpriority>
      public override FieldInfo[] GetFields(BindingFlags bindingAttr)
      {
         return fields.ToArray();
      }

      /// <summary>
      /// When overridden in a derived class, searches for the members defined for the current <see cref="T:System.Type" />, using the specified binding constraints.
      /// </summary>
      /// <returns>
      /// An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing all members defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.MemberInfo" />, if no members are defined for the current <see cref="T:System.Type" />, or if none of the defined members match the binding constraints.
      /// </returns>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><filterpriority>2</filterpriority>
      public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
      {
         List<MemberInfo> ret = new List<MemberInfo>();
         ret.AddRange(methods.ToArray());
         ret.AddRange(constructors.ToArray());
         ret.AddRange(fields.ToArray());
         return ret.ToArray();
      }

      /// <summary>
      /// When overridden in a derived class, implements the <see cref="P:System.Type.Attributes" /> property and gets a bitmask indicating the attributes associated with the <see cref="T:System.Type" />.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.Reflection.TypeAttributes" /> object representing the attribute set of the <see cref="T:System.Type" />.
      /// </returns>
      protected override TypeAttributes GetAttributeFlagsImpl()
      {
         return attributes;
      }

      /// <summary>
      /// When overridden in a derived class, implements the <see cref="P:System.Type.IsArray" /> property and determines whether the <see cref="T:System.Type" /> is an array.
      /// </summary>
      /// <returns>
      /// true if the <see cref="T:System.Type" /> is an array; otherwise, false.
      /// </returns>
      protected override bool IsArrayImpl()
      {
         return elementType != null;
      }

      /// <summary>
      /// When overridden in a derived class, implements the <see cref="P:System.Type.IsByRef" /> property and determines whether the <see cref="T:System.Type" /> is passed by reference.
      /// </summary>
      /// <returns>
      /// true if the <see cref="T:System.Type" /> is passed by reference; otherwise, false.
      /// </returns>
      protected override bool IsByRefImpl()
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// When overridden in a derived class, implements the <see cref="P:System.Type.IsPointer" /> property and determines whether the <see cref="T:System.Type" /> is a pointer.
      /// </summary>
      /// <returns>
      /// true if the <see cref="T:System.Type" /> is a pointer; otherwise, false.
      /// </returns>
      protected override bool IsPointerImpl()
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// When overridden in a derived class, implements the <see cref="P:System.Type.IsPrimitive" /> property and determines whether the <see cref="T:System.Type" /> is one of the primitive types.
      /// </summary>
      /// <returns>
      /// true if the <see cref="T:System.Type" /> is one of the primitive types; otherwise, false.
      /// </returns>
      protected override bool IsPrimitiveImpl()
      {
         return false;
      }

      /// <summary>
      /// When overridden in a derived class, implements the <see cref="P:System.Type.IsCOMObject" /> property and determines whether the <see cref="T:System.Type" /> is a COM object.
      /// </summary>
      /// <returns>
      /// true if the <see cref="T:System.Type" /> is a COM object; otherwise, false.
      /// </returns>
      protected override bool IsCOMObjectImpl()
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// When overridden in a derived class, invokes the specified member, using the specified binding constraints and matching the specified argument list, modifiers and culture.
      /// </summary>
      /// <returns>
      /// An <see cref="T:System.Object" /> representing the return value of the invoked member.
      /// </returns>
      /// <param name="name">The <see cref="T:System.String" /> containing the name of the constructor, method, property, or field member to invoke.-or- An empty string ("") to invoke the default member. -or-For IDispatch members, a string representing the DispID, for example "[DispID=3]".</param>
      /// <param name="invokeAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted. The access can be one of the BindingFlags such as Public, NonPublic, Private, InvokeMethod, GetField, and so on. The type of lookup need not be specified. If the type of lookup is omitted, BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static are used. </param>
      /// <param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. Note that explicitly defining a <see cref="T:System.Reflection.Binder" /> object may be requird for successfully invoking method overloads with variable arguments.</param>
      /// <param name="target">The <see cref="T:System.Object" /> on which to invoke the specified member. </param>
      /// <param name="args">An array containing the arguments to pass to the member to invoke. </param>
      /// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="args" /> array. A parameter's associated attributes are stored in the member's signature. The default binder processes this parameter only when calling a COM component. </param>
      /// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> object representing the globalization locale to use, which may be necessary for locale-specific conversions, such as converting a numeric String to a Double.-or- null to use the current thread's <see cref="T:System.Globalization.CultureInfo" />. </param>
      /// <param name="namedParameters">An array containing the names of the parameters to which the values in the <paramref name="args" /> array are passed. </param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="invokeAttr" /> contains <paramref name="CreateInstance" /> and <paramref name="typeName" /> is null. </exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="args" /> is multidimensional.-or- <paramref name="modifiers" /> is multidimensional.-or- <paramref name="args" /> and <paramref name="modifiers" /> do not have the same length.-or- <paramref name="invokeAttr" /> is not a valid <see cref="T:System.Reflection.BindingFlags" /> attribute.-or- <paramref name="invokeAttr" /> contains <paramref name="CreateInstance" /> combined with <paramref name="InvokeMethod" />, <paramref name="GetField" />, <paramref name="SetField" />, <paramref name="GetProperty" />, or <paramref name="SetProperty" />.-or- <paramref name="invokeAttr" /> contains both <paramref name="GetField" /> and <paramref name="SetField" />.-or- <paramref name="invokeAttr" /> contains both <paramref name="GetProperty" /> and <paramref name="SetProperty" />.-or- <paramref name="invokeAttr" /> contains <paramref name="InvokeMethod" /> combined with <paramref name="SetField" /> or <paramref name="SetProperty" />.-or- <paramref name="invokeAttr" /> contains <paramref name="SetField" /> and <paramref name="args" /> has more than one element.-or- The named parameter array is larger than the argument array.-or- This method is called on a COM object and one of the following binding flags was not passed in: BindingFlags.InvokeMethod, BindingFlags.GetProperty, BindingFlags.SetProperty, BindingFlags.PutDispProperty, or BindingFlags.PutRefDispProperty.-or- One of the named parameter arrays contains a string that is null. </exception>
      /// <exception cref="T:System.MethodAccessException">The specified member is a class initializer. </exception>
      /// <exception cref="T:System.MissingFieldException">The field or property cannot be found. </exception>
      /// <exception cref="T:System.MissingMethodException">The method cannot be found.-or- The current <see cref="T:System.Type" /> object represents a type that contains open type parameters, that is, <see cref="P:System.Type.ContainsGenericParameters" /> returns true. </exception>
      /// <exception cref="T:System.Reflection.TargetException">The specified member cannot be invoked on <paramref name="target" />. </exception>
      /// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one method matches the binding criteria. </exception>
      /// <exception cref="T:System.InvalidOperationException">The method represented by <paramref name="name" /> has one or more unspecified generic type parameters. That is, the method's <see cref="P:System.Reflection.MethodInfo.ContainsGenericParameters" /> property returns true.</exception><filterpriority>2</filterpriority>
      public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// Indicates the type provided by the common language runtime that represents this type.
      /// </summary>
      /// <returns>
      /// The underlying system type for the <see cref="T:System.Type" />.
      /// </returns>
      /// <filterpriority>2</filterpriority>
      public override Type UnderlyingSystemType
      {
         get { throw new System.NotImplementedException(); }
      }

      /// <summary>
      /// When overridden in a derived class, searches for a constructor whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.
      /// </summary>
      /// <returns>
      /// A <see cref="T:System.Reflection.ConstructorInfo" /> object representing the constructor that matches the specified requirements, if found; otherwise, null.
      /// </returns>
      /// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
      /// <param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param>
      /// <param name="callConvention">The <see cref="T:System.Reflection.CallingConventions" /> object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and the stack is cleaned up. </param>
      /// <param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the constructor to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a constructor that takes no parameters. </param>
      /// <param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
      /// <exception cref="T:System.ArgumentNullException"><paramref name="types" /> is null.-or- One of the elements in <paramref name="types" /> is null. </exception>
      /// <exception cref="T:System.ArgumentException"><paramref name="types" /> is multidimensional.-or- <paramref name="modifiers" /> is multidimensional.-or- <paramref name="types" /> and <paramref name="modifiers" /> do not have the same length. </exception>
      protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
      {
         binder = CustomBinder.Default;
         if (constructors.Count == 0)
            return null;

         return (ConstructorInfo)binder.SelectMethod(bindingAttr, constructors.ToArray(), types, modifiers);
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

      ///<summary>
      ///Determines whether an instance of the current <see cref="T:System.Type" /> can be assigned from an instance of the specified Type.
      ///</summary>
      ///
      ///<returns>
      ///true if <paramref name="c" /> and the current Type represent the same type, or if the current Type is in the inheritance hierarchy of <paramref name="c" />, or if the current Type is an interface that <paramref name="c" /> implements, or if <paramref name="c" /> is a generic type parameter and the current Type represents one of the constraints of <paramref name="c" />. false if none of these conditions are true, or if <paramref name="c" /> is null.
      ///</returns>
      ///
      ///<param name="c">The Type to compare with the current Type. </param><filterpriority>2</filterpriority>
      public override bool IsAssignableFrom(System.Type c)
      {
         return AbstractHelper.IsAssignableFrom(this, c);
      }

      /// <summary>
      /// Gets the GUID associated with the <see cref="T:System.Type" />.
      /// </summary>
      /// <returns>
      /// The GUID associated with the <see cref="T:System.Type" />.
      /// </returns>
      /// <filterpriority>1</filterpriority>
      public override Guid GUID
      {
         get { throw new System.NotImplementedException(); }
      }

      /// <summary>
      /// Gets the module (the DLL) in which the current <see cref="T:System.Type" /> is defined.
      /// </summary>
      /// <returns>
      /// The name of the module in which the current <see cref="T:System.Type" /> is defined.
      /// </returns>
      /// <filterpriority>1</filterpriority>
      public override Module Module
      {
         get { throw new System.NotImplementedException(); }
      }

      /// <summary>
      /// Gets the <see cref="T:System.Reflection.Assembly" /> in which the type is declared. For generic types, gets the <see cref="T:System.Reflection.Assembly" /> in which the generic type is defined.
      /// </summary>
      /// <returns>
      /// An <see cref="T:System.Reflection.Assembly" /> instance that describes the assembly containing the current type. For generic types, the instance describes the assembly that contains the generic type definition, not the assembly that creates and uses a particular constructed type.
      /// </returns>
      /// <filterpriority>1</filterpriority>
      public override Assembly Assembly
      {
         get { throw new System.NotImplementedException(); }
      }

      /// <summary>
      /// Gets the fully qualified name of the <see cref="T:System.Type" />, including the namespace of the <see cref="T:System.Type" /> but not the assembly.
      /// </summary>
      /// <returns>
      /// The fully qualified name of the <see cref="T:System.Type" />, including the namespace of the <see cref="T:System.Type" /> but not the assembly; or null if the current instance represents a generic type parameter, an array type, pointer type, or byref type based on a type parameter, or a generic type that is not a generic type definition but contains unresolved type parameters.
      /// </returns>
      /// <filterpriority>1</filterpriority>
      public override string FullName
      {
         get { return namespaceName + Type.Delimiter + name; }
      }

      /// <summary>
      /// Gets the namespace of the <see cref="T:System.Type" />.
      /// </summary>
      /// <returns>
      /// The namespace of the <see cref="T:System.Type" />, or null if the current instance represents a generic parameter.
      /// </returns>
      /// <filterpriority>2</filterpriority>
      public override string Namespace
      {
         get { return namespaceName; }
      }

      /// <summary>
      /// Gets the assembly-qualified name of the <see cref="T:System.Type" />, which includes the name of the assembly from which the <see cref="T:System.Type" /> was loaded.
      /// </summary>
      /// <returns>
      /// The assembly-qualified name of the <see cref="T:System.Type" />, which includes the name of the assembly from which the <see cref="T:System.Type" /> was loaded, or null if the current instance represents a generic type parameter.
      /// </returns>
      /// <filterpriority>2</filterpriority>
      public override string AssemblyQualifiedName
      {
         get { throw new System.NotImplementedException(); }
      }

      /// <summary>
      /// Gets the type from which the current <see cref="T:System.Type" /> directly inherits.
      /// </summary>
      /// <returns>
      /// The <see cref="T:System.Type" /> from which the current <see cref="T:System.Type" /> directly inherits, or null if the current Type represents the <see cref="T:System.Object" /> class or an interface.
      /// </returns>
      /// <filterpriority>2</filterpriority>
      public override Type BaseType
      {
         get { return baseType != null ? (Type)baseType.ReflectionObject : null; }
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

      /// <summary>
      /// Defines a method on this type
      /// </summary>
      /// <param name="name">The name of the method</param>
      /// <param name="attributes">The attributes of the method</param>
      /// <param name="returnType">The return type of the method</param>
      /// <param name="parameterTypes">The parameter types of the method</param>
      /// <param name="parNames">The parameter names of the method</param>
      /// <returns>A new UserMethod instance with the defined method</returns>
      public UserMethod DefineMethod(string name, MethodAttributes attributes, IdEntry returnType, IdEntry[] parameterTypes, String[] parNames)
      {
         if (this.GetMethod(name, BindingFlags.ExactBinding, null, LibraryChecker.ToArray<Type>(parameterTypes), null) != null)
            throw new InvalidOperationException("The member has already been defined on the class");

         UserMethod method = new UserMethod(this.Entry, name, returnType, parameterTypes, parNames, attributes);
         this.methods.Add(method);
         return method;
      }

      /// <summary>
      /// Defines a constructor on this type
      /// </summary>
      /// <param name="attributes">The attributes of the constructor</param>
      /// <param name="parameterTypes">The parameter types of the constructor</param>
      /// <param name="parNames">The parameter names of the constructor</param>
      /// <returns>A new UserConstructor instance with the defined constructor</returns>
      public UserConstructor DefineConstructor(MethodAttributes attributes, IdEntry[] parameterTypes, String[] parNames)
      {
         if (this.GetConstructor(BindingFlags.ExactBinding, null, LibraryChecker.ToArray<Type>(parameterTypes), null) != null)
            throw new InvalidOperationException("The member has already been defined on the class");

         UserConstructor constructor = new UserConstructor(this.Entry, parameterTypes, parNames, attributes);
         this.constructors.Add(constructor);
         return constructor;
      }

      /// <summary>
      /// Defines a type initializer on this type. This is also sometimes called a static constructor. Only one per type is allowed.
      /// </summary>
      /// <returns>The constructor of the static type initializer</returns>
      public UserConstructor DefineTypeInitializer()
      {
         if (staticConstructor == null)
         {
            staticConstructor = new UserConstructor(this.Entry, new IdEntry[] {}, new string[] {},
                                                    MethodAttributes.Static | MethodAttributes.Private | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            return staticConstructor;
         }
         else
            throw new InvalidOperationException("Type '" + this.FullName + "' already has a static constructor.");
      }

      /// <summary>
      /// Defines a field on the current type.
      /// </summary>
      /// <param name="name">The name of the field</param>
      /// <param name="attributes">The attributes of the field</param>
      /// <param name="fieldType">The type of the field</param>
      /// <returns>A UserField instance corresponding to the field defined</returns>
      public UserField DefineField(string name, FieldAttributes attributes, IdEntry fieldType)
      {
         if (this.GetField(name) != null)
            throw new InvalidOperationException("The member has already been defined on the class");
         
         UserField field = new UserField(this.Entry, name, fieldType, attributes);
         this.fields.Add(field);
         return field;
      }

      /// <summary>
      /// Sets the base type of this type
      /// </summary>
      /// <param name="type">The IdEntry of the type to set as base type</param>
      public void SetBaseType(IdEntry type)
      {
         this.baseType = type;
      }

      /// <summary>
      /// Adds an interface (implements) to this type
      /// </summary>
      /// <param name="type">The IdEntry of the interface to implement</param>
      public void AddInterface(IdEntry type)
      {
         Type interfac = (Type) type.ReflectionObject;
         if (!interfac.IsInterface || this.interfaces.Contains(type))
            throw new InvalidOperationException("The type already implements the specified interface");

         this.interfaces.Add(type);
      }

      ///<summary>
      ///Returns a <see cref="T:System.Type" /> object representing a one-dimensional array of the current type, with a lower bound of zero.
      ///</summary>
      ///
      ///<returns>
      ///A <see cref="T:System.Type" /> object representing a one-dimensional array of the current type, with a lower bound of zero.
      ///</returns>
      ///<filterpriority>2</filterpriority>
      public override Type MakeArrayType()
      {
         if (arrayType == null)
            arrayType = new UserType(this.name + "[]", this.namespaceName, this.attributes, this.Entry);
         return arrayType;
      }

      /// <summary>
      /// Gets or sets the IdEntry where this type is defined in the AST
      /// </summary>
      public IdEntry Entry { get; set; }

      /// <summary>
      /// Checks if this type correctly implements all its interfaces and abstract inherited methods
      /// </summary>
      public void CheckInterfaces()
      {
         foreach (Type t in this.GetInterfaces())
         {
            foreach (MethodInfo m in t.GetMethods(BindingFlags.FlattenHierarchy))
            {
               ParameterInfo[] p = m.GetParameters();
               Type[] par = new Type[p.Length];
               for (int i = 0; i < p.Length; i++)
               {
                  par[i] = p[i].ParameterType;
               }
               MethodInfo impl = this.GetMethod(m.Name, BindingFlags.FlattenHierarchy, null, par, null);
               if (impl == null || (!this.IsAbstract && impl.IsAbstract) || impl.ReturnType != m.ReturnType)
                  throw new CheckerException("Interface " + t.FullName + " not completely implemented: method " + m.Name);
            }
         }
         if (baseType != null && !this.IsAbstract && !this.IsInterface)
         {
            foreach (MethodInfo m in BaseType.GetMethods(BindingFlags.FlattenHierarchy))
            {
               if (m.IsAbstract)
               {
                  ParameterInfo[] p = m.GetParameters();
                  Type[] par = new Type[p.Length];
                  for (int i = 0; i < p.Length; i++)
                  {
                     par[i] = p[i].ParameterType;
                  }
                  MethodInfo impl = this.GetMethod(m.Name, BindingFlags.FlattenHierarchy, null, par, null);
                  if (impl == null || impl.IsAbstract)
                     throw new CheckerException("Abstract methods on " + BaseType.FullName + " not overridden: method " + m.Name);
               }
            }
         }
      }
   }
}
