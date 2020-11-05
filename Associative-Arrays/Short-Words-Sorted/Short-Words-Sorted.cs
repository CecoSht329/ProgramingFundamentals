using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> nums = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .OrderByDescending(x => x)
            .Take(3)
            .ToList();

        ;

        Console.WriteLine(string.Join(" ",nums));
    }
}

