using System;
using System.Reflection;

namespace TypeUtility
{
    public static class TypeExtensions
    {
        public static bool IsAssignableFrom(this Type typeOrigin, Type typeToCheck)
        {
#if NET40
            return typeOrigin.IsAssignableFrom(typeToCheck);
#else
            return typeOrigin.GetTypeInfo().IsAssignableFrom(typeToCheck.GetTypeInfo());
#endif
        }
    }
}
