using System;
using System.Linq;
using System.Collections.Generic;


class List_Manipulation_Advanced
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> originalNumbers = new List<int>();
        originalNumbers = numbers;
        int count = 0;
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "end")
            {
                break;
            }

            string[] tokens = line.Split();
            switch (tokens[0])
            {
                case "Add":
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd);
                    count++;
                    break;
                case "Remove":
                    int numbersToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numbersToRemove);
                    count++;
                    break;
                case "RemoveAt":
                    int indexToRemove = int.Parse(tokens[1]);
                    numbers.RemoveAt(indexToRemove);
                    count++;
                    break;
                case "Insert":
                    int numbersToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, numbersToInsert);
                    break;
                    count++;
                case "Contains":
                    int belonging = int.Parse(tokens[1]);
                    if (numbers.Contains(belonging))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;
                case "PrintEven":
                    PrintEven(numbers);
                    break;
                case "PrintOdd":
                    PrintOdd(numbers);
                    break;
                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;
                case "Filter":
                    int numberToCompare = int.Parse(tokens[2]);
                    switch (tokens[1])
                    {
                        case "<":
                            PrintLess(numbers, numberToCompare);
                            break;
                        case ">":
                            PrintMore(numbers, numberToCompare);
                            break;
                        case ">=":
                            PrintMoreOrEqual(numbers, numberToCompare);
                            break;
                        case "<=":
                            PrintLessOrEqual(numbers, numberToCompare);
                            break;
                    }
                    break;
            }
        }
        if (count > 0)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }

    private static void PrintLessOrEqual(List<int> numbers, int numberToCompare)
    {
        List<int> lessOrEqual = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] <= numberToCompare)
            {
                lessOrEqual.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ", lessOrEqual));
    }

    private static void PrintMoreOrEqual(List<int> numbers, int numberToCompare)
    {
        List<int> moreOrEqual = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] >= numberToCompare)
            {
                moreOrEqual.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ", moreOrEqual));
    }

    private static void PrintMore(List<int> numbers, int numberToCompare)
    {
        List<int> more = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > numberToCompare)
            {
                more.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ", more));
    }

    private static void PrintLess(List<int> numbers, int numberToCompare)
    {
        List<int> less = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < numberToCompare)
            {
                less.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ", less));
    }

    private static void GetLessOrEqual(List<int> numbers, int numberToCompare)
    {
        List<int> numbers2 = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] <= numberToCompare)
            {
                numbers2.Add(numbers[i]);
            }
        }
    }



    private static void PrintOdd(List<int> numbers)
    {
        List<int> oddNumbers = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 1)
            {
                oddNumbers.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ", oddNumbers));
    }

    private static void PrintEven(List<int> numbers)
    {
        List<int> evenNumbers = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNumbers.Add(numbers[i]);
            }
        }
        Console.WriteLine(string.Join(" ", evenNumbers));
    }
}

