using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        //int numberToconvert = numbers[1];
        //int baseToConvertTo = numbers[0];
        BigInteger numberToconvert = BigInteger.Parse(numbers[1]);
        int @base = int.Parse(numbers[0]);

        StringBuilder converted = new StringBuilder();
        while (numberToconvert > 0)
        {
            BigInteger digit = numberToconvert % @base;
            converted.Insert(0, digit);
            numberToconvert = numberToconvert / @base;
        }
        Console.WriteLine(string.Join("", converted));
    }
}

