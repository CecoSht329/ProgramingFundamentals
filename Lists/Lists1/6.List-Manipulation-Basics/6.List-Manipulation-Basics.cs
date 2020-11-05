using System;
using System.Collections.Generic;
using System.Linq;

class List_Manipulation_Basics
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

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
                    break;
                case "Remove":
                    int numbersToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numbersToRemove);
                    break;
                case "RemoveAt":
                    int indexToRemove = int.Parse(tokens[1]);
                    numbers.RemoveAt(indexToRemove);
                    break;
                case "Insert":
                    int numbersToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, numbersToInsert);
                    break;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
