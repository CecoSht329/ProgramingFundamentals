using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        BigInteger bigint = 1;

        for (int i = number; i > 0; i--)
        {
            bigint *= i;
        }
        Console.WriteLine(bigint);
    }
}
