﻿using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintResult(n);
    }

    private static void PrintResult(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
