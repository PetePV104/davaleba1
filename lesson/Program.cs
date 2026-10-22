using System;
using System.Collections.Generic;

static class MyExtensions
{
    public static IEnumerable<T> CustomWhere<T>(
        this IEnumerable<T> collection, Predicate<T> predicate)
    {
        foreach (var item in collection)
        {
            if (predicate(item))
                yield return item;
        }
    }

    public static T? CustomFirstOrDefault<T>(
        this IEnumerable<T> collection, Predicate<T> predicate)
    {
        foreach (var item in collection)
        {
            if (predicate(item))
                return item;
        }
        return default;
    }

    public static bool CustomAny<T>(
        this IEnumerable<T> collection, Predicate<T> predicate)
    {
        foreach (var item in collection)
        {
            if (predicate(item))
                return true;
        }
        return false;
    }

    public static bool CustomAll<T>(
        this IEnumerable<T> collection, Predicate<T> predicate)
    {
        foreach (var item in collection)
        {
            if (!predicate(item))
                return false;
        }
        return true;
    }

    public static int CustomCount<T>(
        this IEnumerable<T> collection, Predicate<T> predicate)
    {
        int count = 0;

        foreach (var item in collection)
        {
            if (predicate(item))
                count++;
        }
        return count;
    }
}