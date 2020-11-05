using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int linesCount = int.Parse(Console.ReadLine());
        int[] firstArray = new int[linesCount];
        int[] secondArray = new int[linesCount];

        for (int i = 0; i < linesCount; i++)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            if (i % 2 == 0)
            {
                firstArray[i] = numbers[0];
                secondArray[i] = numbers[1];
            }
            else
            {
                firstArray[i] = numbers[1];
                secondArray[i] = numbers[0];
            }

        }
        Console.WriteLine(String.Join(" ", firstArray));
        Console.WriteLine(String.Join(" ", secondArray));
    }
}

