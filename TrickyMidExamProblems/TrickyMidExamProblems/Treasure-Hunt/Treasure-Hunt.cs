using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> chest = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

        string input;
        bool isFailed = false;
        while ((input = Console.ReadLine()) != "Yohoho!")
        {
            string[] commands = input.Split(" ").ToArray();
            string command = commands[0];
            switch (command)
            {
                case "Loot":
                    for (int i = 1; i < commands.Length; i++)
                    {
                        string item = commands[i];
                        if (!chest.Contains(item))
                        {
                            chest.Insert(0, item);
                        }
                    }
                    //Console.WriteLine(string.Join(" ", chest));
                    break;
                case "Drop":
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index <= chest.Count - 1)
                    {
                        string loot = chest[index];
                        chest.RemoveAt(index);
                        chest.Add(loot);
                    }
                    //Console.WriteLine(string.Join(" ", chest));
                    break;
                case "Steal":
                    int count = int.Parse(commands[1]);
                    List<string> stolenItems = new List<string>();
                    if (count >= chest.Count)
                    {
                        for (int i = 0; i < chest.Count; i++)
                        {
                            stolenItems.Add(chest[i]);
                        }

                        chest.Clear();
                    }
                    else
                    {
                        for (int i = chest.Count - 1; i >= chest.Count - count; i--)
                        {
                            stolenItems.Add(chest[i]);
                        }
                        foreach (string item in stolenItems)
                        {
                            chest.Remove(item);
                        }
                        stolenItems.Reverse();
                    }
                    Console.WriteLine(string.Join(", ", stolenItems));
                    if (chest.Count == 0)
                    {
                        isFailed = true;
                        Console.WriteLine("Failed treasure hunt.");
                    }
                    break;
            }
        }
        if (!isFailed)
        {
            double sum = 0;
            for (int i = 0; i < chest.Count; i++)
            {
                sum += chest[i].Length;
            }
            double average = sum / chest.Count;
            Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
        }
    }
}
