
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40 };

        ArrayHelper.PrintReverse(numbers);

        Console.WriteLine(ArrayHelper.GetFirstElement(numbers));
        Console.WriteLine(ArrayHelper.GetLastElement(numbers));
        Console.WriteLine(ArrayHelper.ContainsElement(numbers, 30));
        Console.WriteLine(ArrayHelper.CountElements(numbers));
        Console.WriteLine(ArrayHelper.FindIndex(numbers, 30));
    }
}
