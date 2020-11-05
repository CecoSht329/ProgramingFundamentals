using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int sumEven = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            if (currentNumber % 2 == 0)
            {
                sumEven += currentNumber;
            }
        }
        Console.WriteLine(sumEven);
    }
}

