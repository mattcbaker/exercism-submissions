using System;
using System.Collections.Generic;

static class IEnumerableExtensions
{
    public static IEnumerable<T> Keep<T>(this ICollection<T> list, Func<T, bool> predicate)
    {
        return list.Filter<T>(predicate);
    }

    public static IEnumerable<T> Discard<T>(this ICollection<T> list, Func<T, bool> predicate)
    {
        return list.Filter<T>(x => !predicate(x));
    }

    private static IEnumerable<T> Filter<T>(this ICollection<T> list, Func<T, bool> predicate)
    {
        foreach(var item in list)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }
}