﻿using System;
using System.Linq;
using System.Collections.Generic;


class SumAdjacentEqualNumbers
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        for (int i = 0; i < numbers.Count-1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] += numbers[i + 1]hui;
                numbers.RemoveAt(i + 1);
                i = -1;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
