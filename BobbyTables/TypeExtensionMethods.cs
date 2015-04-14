using System;
using System.Reflection;

namespace BobbyTables
{
	public static class TypeExtensionMethods
	{
		public static bool IsEnum(this Type type)
		{
			return type.IsEnum;
		}

		public static bool IsGenericType(this Type type)
		{
			return type.IsGenericType;
		}

		public static Type[] GetGenericArguments(this Type type)
		{
			return type.GetGenericArguments();
		}

		public static Type[] GetInterfaces(this Type type)
		{
			return type.GetInterfaces();
		}

		public static bool IsIgnored(this MemberInfo memberInfo)
		{
			return memberInfo.GetCustomAttributes(typeof(IgnoreAttribute), true).Length != 0;
		}
	}
}
