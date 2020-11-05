using System;

namespace Draskanica
{
    class Program
    {
        static void PrintTriangle(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int row = 1; row <= input; row++)
            {
                PrintTriangle(row);
            }
            for (int row = input - 1; row >= 1; row--)
            {
                PrintTriangle(row);
            }
        }
    }
}
