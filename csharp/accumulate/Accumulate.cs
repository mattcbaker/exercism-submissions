using System;
using System.Collections.Generic;

namespace accumulate
{
    static class IEnumerableExtensions
    {
        public static IEnumerable<T> Accumulate<T>(this IEnumerable<T> collection, Func<T, T> transform)
        {
            foreach(var item in  collection)
            {
                yield return transform(item);
            }
        }
    }
}