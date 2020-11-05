using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int[] numbers2 = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

        for (int i = 0; i < numbers2.Length; i++)
        {
            int firstCurrent = numbers[i];
            int secondCurrent = numbers2[i];
            if (firstCurrent != secondCurrent)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                break;
            }
            if (i == numbers2.Length - 1 && numbers2[numbers2.Length - 1] == numbers[numbers.Length - 1])
            {
                Console.WriteLine($"Arrays are identical. Sum: {numbers2.Sum()}");
            }
        }
    }
}

