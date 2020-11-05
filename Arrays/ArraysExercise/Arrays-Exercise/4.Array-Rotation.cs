using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int rotations = int.Parse(Console.ReadLine());
                                       //↓this is optional in case you have as much roatations as the numbers in the array
        for (int i = 0; i < rotations % numbers.Length; i++)
        {
            int firstNum = numbers[0];
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                numbers[j] = numbers[j + 1];
            }
            numbers[numbers.Length - 1] = firstNum;
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}

