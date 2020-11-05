using System;
using System.Linq;
using System.Collections.Generic;

class Train
{
    static void Main()
    {
        List<int> train = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
        int maxWagonCapacity = int.Parse(Console.ReadLine());

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                Console.WriteLine(string.Join(" ", train));
                break;
            }
            if (input.Contains("Add"))
            {
                string[] tokens = input.Split();
                int number = int.Parse(tokens[1]);
                train.Add(number);
            }
            else
            {
                int number = int.Parse(input);
                for (int i = 0; i < train.Count; i++)
                {
                    if (train[i] + number <= maxWagonCapacity)
                    {
                        train[i] += number;
                        break;
                    }
                }
            }
        }
    }
}

