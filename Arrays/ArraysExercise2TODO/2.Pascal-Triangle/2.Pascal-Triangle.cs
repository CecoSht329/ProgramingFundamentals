using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());//инициализираме брой редове 
        Console.WriteLine(1);
        if (row == 1)
        {
            return;
        }

        int[] previousArray = new int[] { 1, 1 };
        Console.WriteLine(string.Join(" ", previousArray));

        if (row == 2)
        {
            return;
        }
        for (int i = 3; i <= row; i++)
        {
            int[] nextArray = new int[previousArray.Length + 1];
            for (int j = 1; j < nextArray.Length - 1; j++)
            {
                nextArray[0] = 1;
                nextArray[nextArray.Length - 1] = 1;

                nextArray[j] = previousArray[j - 1] + previousArray[j];
            }
            Console.WriteLine(string.Join(" ", nextArray));
            previousArray = nextArray;
        }
    }
}

