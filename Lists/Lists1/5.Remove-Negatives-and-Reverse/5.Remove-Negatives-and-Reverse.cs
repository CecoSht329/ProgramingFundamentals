﻿using System;
using System.Linq;
using System.Collections.Generic;


class RemoveNegativesandReverse
{
    static void Main()
    {

        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        List<int> positiveNumbers = new List<int>();
        foreach (int number in numbers)
        {
            if (number >= 0)
            {
                positiveNumbers.Add(number);
            }
        }
        positiveNumbers.Reverse();
        if (positiveNumbers.Count > 0)
        {
            Console.WriteLine(string.Join(" ", positiveNumbers));
        }
        else
        {
            Console.WriteLine("empty");
        }

    }
}
