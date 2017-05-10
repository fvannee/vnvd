using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Vnvd.UserDefined
{
   /// <summary>
   /// Class to represent a method parameter
   /// </summary>
   class UserParameter : ParameterInfo
   {
      private IdEntry entry;

      /// <summary>
      /// Creates a new parameter with given type, name and position
      /// </summary>
      /// <param name="type">The type of the parameter</param>
      /// <param name="name">The name of the parameter</param>
      /// <param name="position">The position of the parameter in the parameter list of the method it belongs to</param>
      public UserParameter(IdEntry type, String name, int position)
      {
         this.AttrsImpl = ParameterAttributes.None;
         this.NameImpl = name;
         this.ClassImpl = (Type) type.ReflectionObject;
         this.entry = type;
         this.PositionImpl = position;
      }

      /// <summary>
      /// Creates a new parameter with given type, name and position
      /// </summary>
      /// <param name="type">The type of the parameter</param>
      /// <param name="position">The position of the parameter in the parameter list of the method it belongs to</param>
      public UserParameter(IdEntry type, int position)
      {
         this.AttrsImpl = ParameterAttributes.None;
         this.ClassImpl = (Type)type.ReflectionObject;
         this.PositionImpl = position;
      }

      /// <summary>
      /// Creates a new parameter with given type, name and position
      /// </summary>
      /// <param name="type">The type of the parameter</param>
      public UserParameter(IdEntry type)
      {
         this.AttrsImpl = ParameterAttributes.None;
         this.ClassImpl = (Type)type.ReflectionObject;
      }

      /// <summary>
      /// Creates a new parameter with given type, name and position
      /// </summary>
      /// <param name="type">The type of the parameter</param>
      /// <param name="attributes">The parameter attributes of this parameter</param>
      public UserParameter(IdEntry type, ParameterAttributes attributes)
      {
         this.AttrsImpl = attributes;
         this.ClassImpl = (Type)type.ReflectionObject;
      }

      /// <summary>
      /// Gets the type of this parameter
      /// </summary>
      public override Type ParameterType
      {
         get
         {
            return (Type)entry.ReflectionObject;
         }
      }
   }
}
