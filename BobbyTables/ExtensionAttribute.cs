using System;

#pragma warning disable 1685
namespace System.Runtime.CompilerServices
{
	[AttributeUsage(AttributeTargets.Method |
	AttributeTargets.Class | AttributeTargets.Assembly)]
	public sealed class ExtensionAttribute : Attribute
	{
	}
}
