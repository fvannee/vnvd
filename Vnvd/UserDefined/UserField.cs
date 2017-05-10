using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Vnvd.UserDefined
{
   /// <summary>
   /// Class to represent a user-defined field
   /// </summary>
   class UserField : FieldInfo
   {
      private string name;
      private FieldAttributes attributes;
      private IdEntry declaringType, fieldType;

      /// <summary>
      /// Creates a new UserField instance with the given parameters
      /// </summary>
      /// <param name="declaringType">The type which declares the field</param>
      /// <param name="name">The name of the field</param>
      /// <param name="fieldType">The type of the field</param>
      /// <param name="attributes">The attributes of the field</param>
      public UserField(IdEntry declaringType, String name, IdEntry fieldType, FieldAttributes attributes)
      {
         this.declaringType = declaringType;
         this.name = name;
         this.fieldType = fieldType;
         this.attributes = attributes;
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
         throw new System.InvalidOperationException();
      }

      /// <summary>
      /// When overridden in a derived class, returns the value of a field supported by a given object.
      /// </summary>
      /// <returns>
      /// An object containing the value of the field reflected by this instance.
      /// </returns>
      /// <param name="obj">The object whose field value will be returned. </param>
      /// <exception cref="T:System.Reflection.TargetException">The field is non-static and <paramref name="obj" /> is null. </exception>
      /// <exception cref="T:System.NotSupportedException">A field is marked literal, but the field does not have one of the accepted literal types. </exception>
      /// <exception cref="T:System.FieldAccessException">The caller does not have permission to access this field. </exception>
      /// <exception cref="T:System.ArgumentException">The method is neither declared nor inherited by the class of <paramref name="obj" />. </exception>
      public override object GetValue(object obj)
      {
         throw new System.NotImplementedException();
      }

      /// <summary>
      /// When overridden in a derived class, sets the value of the field supported by the given object.
      /// </summary>
      /// <param name="obj">The object whose field value will be set. </param>
      /// <param name="value">The value to assign to the field. </param>
      /// <param name="invokeAttr">A field of Binder that specifies the type of binding that is desired (for example, Binder.CreateInstance or Binder.ExactBinding). </param>
      /// <param name="binder">A set of properties that enables the binding, coercion of argument types, and invocation of members through reflection. If <paramref name="binder" /> is null, then Binder.DefaultBinding is used. </param>
      /// <param name="culture">The software preferences of a particular culture. </param>
      /// <exception cref="T:System.FieldAccessException">The caller does not have permission to access this field. </exception>
      /// <exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the field is an instance field. </exception>
      /// <exception cref="T:System.ArgumentException">The field does not exist on the object.-or- The <paramref name="value" /> parameter cannot be converted and stored in the field. </exception>
      public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
      {
         throw new System.NotImplementedException();
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
      /// Gets the type of this field object.
      /// </summary>
      /// <returns>
      /// The type of this field object.
      /// </returns>
      public override Type FieldType
      {
         get { return (Type)fieldType.ReflectionObject; }
      }

      /// <summary>
      /// Gets the attributes associated with this field.
      /// </summary>
      /// <returns>
      /// The FieldAttributes for this field.
      /// </returns>
      public override FieldAttributes Attributes
      {
         get { return attributes; }
      }

      /// <summary>
      /// Gets a RuntimeFieldHandle, which is a handle to the internal metadata representation of a field.
      /// </summary>
      /// <returns>
      /// A handle to the internal metadata representation of a field.
      /// </returns>
      public override RuntimeFieldHandle FieldHandle
      {
         get { throw new System.NotImplementedException(); }
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
      /// Gets the IdEntry where this field is defined in the AST
      /// </summary>
      public IdEntry Entry { get; set; }

      /// <summary>
      /// Gets or sets the constant value of this field. Only supported for literal fields
      /// </summary>
      public Object ConstantValue { get; set; }
   }
}
