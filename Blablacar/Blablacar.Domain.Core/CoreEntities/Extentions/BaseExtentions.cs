using System;

namespace Blablacar.Domain.Core
{
    public static class BaseExtentions
    {
        public static T CheckForNull<T>(this T targetObject) => 
            targetObject 
            ?? throw new ArgumentNullException(nameof(targetObject));
       

        public static string CheckForNull(this string targetString)
        {
            if (string.IsNullOrEmpty(targetString))
                throw new ArgumentNullException(nameof(targetString));

            return targetString;
        }
    }
}
