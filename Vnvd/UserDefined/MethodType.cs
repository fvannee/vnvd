using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Vnvd.UserDefined
{
   /// <summary>
   /// Class to represent a delegate, that is, a pointer to a method.
   /// </summary>
   class MethodType : Type
   {
      private static Dictionary<MethodInfo, MethodType> methods = new Dictionary<MethodInfo, MethodType>();

      /// <summary>
      /// Gets the MethodType corresponding to the specified method
      /// </summary>
      /// <param name="method">The method to get the MethodType for</param>
      /// <returns>A MethodType instance of the specified method</returns>
      public static MethodType GetMethodType(MethodInfo method)
      {
         if (methods.ContainsKey(method))
         {
            return methods[method];
         }
         else
         {
            MethodType t = new MethodType(method);
            methods[method] = t;
            return t;
         }
      }

      private MethodInfo method;

      private MethodType(MethodInfo method)
      {
         this.method = method;
      }

      public override bool Equals(object o)
      {
         if (o is MethodType)
         {
            return ((MethodType)o).method.Equals(this.method);
         }
         return false;
      }

      public override System.Reflection.Assembly Assembly
      {
         get { throw new NotImplementedException(); }
      }

      public override string AssemblyQualifiedName
      {
         get { throw new NotImplementedException(); }
      }

      public override Type BaseType
      {
         get { throw new NotImplementedException(); }
      }

      public override string FullName
      {
         get { throw new NotImplementedException(); }
      }

      public override Guid GUID
      {
         get { throw new NotImplementedException(); }
      }

      protected override System.Reflection.TypeAttributes GetAttributeFlagsImpl()
      {
         throw new NotImplementedException();
      }

      protected override System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, Type[] types, System.Reflection.ParameterModifier[] modifiers)
      {
         throw new NotImplementedException();
      }

      public override System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr)
      {
         throw new NotImplementedException();
      }

      public override Type GetElementType()
      {
         throw new NotImplementedException();
      }

      public override System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr)
      {
         throw new NotImplementedException();
      }

      public override System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr)
      {
         throw new NotImplementedException();
      }

      public override System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr)
      {
         throw new NotImplementedException();
      }

      public override System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr)
      {
         throw new NotImplementedException();
      }

      public override Type GetInterface(string name, bool ignoreCase)
      {
         throw new NotImplementedException();
      }

      public override Type[] GetInterfaces()
      {
         throw new NotImplementedException();
      }

      public override System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr)
      {
         throw new NotImplementedException();
      }

      protected override System.Reflection.MethodInfo GetMethodImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, Type[] types, System.Reflection.ParameterModifier[] modifiers)
      {
         throw new NotImplementedException();
      }

      public override System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr)
      {
         throw new NotImplementedException();
      }

      public override Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr)
      {
         throw new NotImplementedException();
      }

      public override Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr)
      {
         throw new NotImplementedException();
      }

      public override System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr)
      {
         throw new NotImplementedException();
      }

      protected override System.Reflection.PropertyInfo GetPropertyImpl(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, Type returnType, Type[] types, System.Reflection.ParameterModifier[] modifiers)
      {
         throw new NotImplementedException();
      }

      protected override bool HasElementTypeImpl()
      {
         throw new NotImplementedException();
      }

      public override object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters)
      {
         throw new NotImplementedException();
      }

      protected override bool IsArrayImpl()
      {
         throw new NotImplementedException();
      }

      protected override bool IsByRefImpl()
      {
         throw new NotImplementedException();
      }

      protected override bool IsCOMObjectImpl()
      {
         throw new NotImplementedException();
      }

      protected override bool IsPointerImpl()
      {
         throw new NotImplementedException();
      }

      protected override bool IsPrimitiveImpl()
      {
         throw new NotImplementedException();
      }

      public override System.Reflection.Module Module
      {
         get { throw new NotImplementedException(); }
      }

      public override string Namespace
      {
         get { throw new NotImplementedException(); }
      }

      public override Type UnderlyingSystemType
      {
         get { throw new NotImplementedException(); }
      }

      public override object[] GetCustomAttributes(Type attributeType, bool inherit)
      {
         throw new NotImplementedException();
      }

      public override object[] GetCustomAttributes(bool inherit)
      {
         throw new NotImplementedException();
      }

      public override bool IsDefined(Type attributeType, bool inherit)
      {
         throw new NotImplementedException();
      }

      public override string Name
      {
         get { throw new NotImplementedException(); }
      }

      public bool Equals(MethodType other)
      {
         if (ReferenceEquals(null, other)) return false;
         if (ReferenceEquals(this, other)) return true;
         return base.Equals(other) && Equals(other.method, method);
      }

      public override int GetHashCode()
      {
         unchecked
         {
            {
               return (base.GetHashCode() * 397) ^ (method != null ? method.GetHashCode() : 0);
            }
         }
      }
   }
}
