using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] tokens = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        int @base = int.Parse(tokens[0]);
        string numAsString = tokens[1];

        BigInteger sum = 0;
        int pow = 0;
        for (int i = numAsString.Length - 1; i >= 0; i--)
        {
            char currentChar = numAsString[i];
            int currentNumber = int.Parse(currentChar.ToString());

            BigInteger currentSum = currentNumber * BigInteger.Pow(@base, pow);
            pow++;
            sum += currentSum;
        }
        Console.WriteLine(sum);
    }
}

