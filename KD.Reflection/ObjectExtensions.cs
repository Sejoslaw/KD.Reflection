using System;
using System.Reflection;

namespace KD.Reflection
{
    /// <summary>
    /// Class which adds various extension methods for Object class.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Call method by it's Name, Constructor arguments, BindingFlags, and argument types.
        /// </summary>
        public static TResult CallMethod<TResult>(this object source, string methodName, object[] args = null, BindingFlags? flags = null, Type[] types = null)
        {
            if (methodName == null || methodName.Equals(""))
            {
                throw new Exception($"Method name is null or empty ({ methodName })");
            }

            var sourceType = source.GetType();
            MethodInfo method = null;
            if (flags != null)
            {
                method = sourceType.GetMethod(methodName, (BindingFlags)flags);
            }
            else if (types != null)
            {
                method = sourceType.GetMethod(methodName, types);
            }
            else
            {
                method = sourceType.GetMethod(methodName);
            }

            var result = method.Invoke(source, args);
            return (TResult)result;
        }
    }
}