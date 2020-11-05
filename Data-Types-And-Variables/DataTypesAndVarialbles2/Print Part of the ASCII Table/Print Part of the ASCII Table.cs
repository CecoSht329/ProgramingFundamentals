using System;

namespace Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num; i <= num2; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
