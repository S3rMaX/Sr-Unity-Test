using System;
using System.Collections.Generic;
using static UnityEngine.UI.Image;
using Unity.VisualScripting;

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

/**
 * 
A.By making use of a generic type parameter T in the method signature, 
    the FilterCollection method can now receive any kind of collection that implements the IEnumerable<T> interface, 
    such as arrays, lists, dictionaries, and so on.

B. The generic type parameter T also allows the FilterCollection method to work with any kind of value, 
    not just integers.

C. The Evaluate method is removed, and instead, a Func<T, bool> parameter is added to the FilterCollection method signature.
    This parameter will be used as a predicate function to determine whether or not an element should be included 
    in the filtered collection. The predicate function can be defined at runtime when the FilterCollection method is called.

D. The FilterCollection method is implemented as an extension method for the IEnumerable<T> interface, \
    which means it can be called directly from any collection that implements that interface. 
    In the example given in the question, the method can be called like this:

    int[] original = new int[] { 1, 2, 3 };
    int[] filtered = original.FilterCollection(x => x > 1).ToArray();

E.The FilterCollection method is implemented as an iterator block that uses the yield keyword to return elements
    one at a time. This makes it a lazy collection, because it only evaluates the predicate function for each 
    element as it is requested, rather than eagerly evaluating the entire collection upfront.

**/