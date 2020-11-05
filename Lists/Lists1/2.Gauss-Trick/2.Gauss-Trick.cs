using System;
using System.Linq;
using System.Collections.Generic;

class GaussTrick
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int originalLength = numbers.Count / 2;
        for (int i = 0; i < originalLength; i++)
        {
            numbers[i] += numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
        }
        Console.WriteLine(string.Join(" ",numbers));
    }
}

