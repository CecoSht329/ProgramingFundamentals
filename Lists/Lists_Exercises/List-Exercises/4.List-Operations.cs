using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "End")
                {
                    break;
                }

                if (command == "Add")
                {
                    AddToCollection(numbers, input);
                }
                else if (command == "Insert")
                {
                    InsertInCollection(numbers, input);
                }
                else if (command == "Remove")
                {
                    RemoveFromCollection(numbers, input);

                }
                else if (command == "Shift")
                {
                    Shift(numbers, input);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Shift(List<int> numbers, string[] input)
        {
            string direction = input[1];
            int rotations = int.Parse(input[2]);

            if (direction == "left")
            {
                ShiftLeft(numbers, rotations);
            }
            else
            {
                ShiftRight(numbers, rotations);
            }
        }

        private static void ShiftRight(List<int> numbers, int rotations)
        {
            for (int i = 0; i < rotations % numbers.Count; i++)
            {
                int lastNum = numbers[numbers.Count - 1];
                numbers.Insert(0, lastNum);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

        private static void ShiftLeft(List<int> numbers, int rotations)
        {
            for (int i = 0; i < rotations % numbers.Count; i++)
            {
                int firstNum = numbers[0];
                numbers.Add(firstNum);
                numbers.RemoveAt(0);
            }
        }

        private static void RemoveFromCollection(List<int> numbers, string[] input)
        {
            int index = int.Parse(input[1]);
            if (index < 0 || index > numbers.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {

                numbers.RemoveAt(index);
            }
        }

        private static void InsertInCollection(List<int> numbers, string[] input)
        {
            int numberToInsert = int.Parse(input[1]);
            int index = int.Parse(input[2]);


            if (index < 0 || index >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.Insert(index, numberToInsert);
            }
        }

        private static void AddToCollection(List<int> numbers, string[] input)
        {
            int number = int.Parse(input[1]);
            numbers.Add(number);
        }
    }
}

