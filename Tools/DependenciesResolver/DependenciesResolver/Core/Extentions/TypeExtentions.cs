using System;

namespace DependenciesResolver.Core
{
    public static class TypeExtentions
    {
        public static Type CheckForSubClassWithException(this Type type, Type parent)
        {
            if (!type.IsSubclassOf(parent))
                throw new InvalidOperationException("Classes are not related");

            return type;
        }
    }
}
