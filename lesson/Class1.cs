
using System;

class ArrayHelper
{
    public static void PrintReverse<T>(T[] arr)
    {
        for (int i = CountElements(arr) - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }

    public static T GetFirstElement<T>(T[] arr)
    {
        return arr[0];
    }

    public static T GetLastElement<T>(T[] arr)
    {
        return arr[CountElements(arr) - 1];
    }

    public static bool ContainsElement<T>(T[] arr, T value)
    {
        foreach (T item in arr)
        {
            if (item.Equals(value))
                return true;
        }

        return false;
    }

    public static int CountElements<T>(T[] arr)
    {
        int count = 0;

        foreach (T item in arr)
        {
            count++;
        }

        return count;
    }

    public static int FindIndex<T>(T[] arr, T value)
    {
        for (int i = 0; i < CountElements(arr); i++)
        {
            if (arr[i].Equals(value))
                return i;
        }

        return -1;
    }
}
