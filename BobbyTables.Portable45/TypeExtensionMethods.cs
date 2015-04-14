using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BobbyTables
{
	public static class TypeExtensionMethods
	{
		public static FieldInfo GetField(this Type type, String propertyName)
		{
			return type.GetTypeInfo().GetDeclaredField(propertyName);
		}

		public static IEnumerable<FieldInfo> GetFields(this Type type)
		{
			return type.GetTypeInfo().DeclaredFields;
		}

		public static PropertyInfo GetProperty(this Type type, String propertyName)
		{
			return type.GetTypeInfo().GetDeclaredProperty(propertyName);
		}

		public static IEnumerable<PropertyInfo> GetProperties(this Type type)
		{
			return type.GetTypeInfo().DeclaredProperties;
		}

		public static MethodInfo GetMethod(this Type type, String methodName)
		{
			return type.GetTypeInfo().GetDeclaredMethod(methodName);
		}

		public static IEnumerable<MethodInfo> GetMethods(this Type type)
		{
			return type.GetTypeInfo().DeclaredMethods;
		}

		public static bool IsAssignableFrom(this Type type, Type parentType)
		{
			return type.GetTypeInfo().IsAssignableFrom(parentType.GetTypeInfo());
		}

		public static bool IsEnum(this Type type)
		{
			return type.GetTypeInfo().IsEnum;
		}

		public static bool IsGenericType(this Type type)
		{
			return type.GetTypeInfo().IsGenericType;
		}

		public static Type[] GetGenericArguments(this Type type)
		{
			return type.GetTypeInfo().GenericTypeArguments;
		}

		public static IEnumerable<Type> GetInterfaces(this Type type)
		{
			return type.GetTypeInfo().ImplementedInterfaces;
		}

		public static bool IsIgnored(this MemberInfo memberInfo)
		{
			return memberInfo.GetCustomAttributes(typeof(IgnoreAttribute), true).Any();
		}
	}
}
