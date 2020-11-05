using System;
using System.Linq;
using System.Collections.Generic;

class Change_List
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        string command; 
        while ((command= Console.ReadLine())!="end")
        {
            string[] parts = command.Split();
            if (parts.Contains("Delete"))
            {
                int element = int.Parse(parts[1]);
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (element == numbers[i])
                    {
                        numbers.Remove(element);
                    }
                }
            }
            else if (parts.Contains("Insert"))
            {
                int element = int.Parse(parts[1]);
                int index = int.Parse(parts[2]);
                numbers.Insert(index, element);
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}

