using System;
using System.Collections.Generic;

public static class CollectionExtensions
{
    public static IEnumerable<T> FilterCollection<T>(this IEnumerable<T> originalCollection, Func<T, bool> predicate)
    {
        foreach (T element in originalCollection)
        {
            if (predicate(element))
            {
                yield return element;
            }
        }
    }
}
