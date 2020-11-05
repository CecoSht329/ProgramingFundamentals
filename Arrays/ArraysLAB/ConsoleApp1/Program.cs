using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] condensedArr = new int[array.Length - 1];
        if (array.Length == 1)
        {
            Console.WriteLine(array[0]);
            return;
        }
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < condensedArr.Length - i; j++)
            {
                condensedArr[j] = array[j] + array[j + 1];
            }
            condensedArr = array;
        }
        Console.WriteLine(condensedArr[0]);
    }
}
