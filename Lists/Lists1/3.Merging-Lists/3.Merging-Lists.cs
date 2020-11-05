using System;
using System.Linq;
using System.Collections.Generic;

class MergingLists
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> resultNums = new List<int>();

        for (int i = 0; i < Math.Max(numbers.Count, numbers2.Count); i++)
        {
            if (i < numbers.Count)
            {
                resultNums.Add(numbers[i]);
            }

            if (i < numbers2.Count)
            {
                resultNums.Add(numbers2[i]);
            }
        }
        Console.WriteLine(string.Join(" ", resultNums));
    }
}

