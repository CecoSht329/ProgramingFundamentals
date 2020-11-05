using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        //Tricky part how to get the count
        List<string> frogs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

        string input;
        while (true)
        {
            input = Console.ReadLine();
            string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = commands[0];
            string name; int index; int count;
            if (command == "Join")
            {
                name = commands[1];
                frogs.Add(name);
            }
            else if (command == "Jump")
            {
                name = commands[1];
                index = int.Parse(commands[2]);
                if (index >= 0 && index < frogs.Count)
                {
                    frogs.Insert(index, name);
                }
            }
            else if (command == "Dive")
            {
                index = int.Parse(commands[1]);
                if (index >= 0 && index < frogs.Count)
                {
                    frogs.RemoveAt(index);
                }
            }
            else if (command == "First" || command == "Last")
            {
                bool isCountMore = false;
                count = int.Parse(commands[1]);///tricky part
                if (count >= frogs.Count)
                {
                    isCountMore = true;
                }
                if (command == "First")
                {
                    if (isCountMore)
                    {
                        Console.WriteLine(string.Join(" ", frogs));
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"{frogs[i]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (command == "Last")
                {
                    if (isCountMore)
                    {
                        Console.WriteLine(string.Join(" ", frogs));
                    }
                    else
                    {
                        for (int i = frogs.Count - count; i < frogs.Count; i++)
                        {
                            Console.Write($"{frogs[i]} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (command == "Print")
            {
                string subcommand = commands[1];
                if (subcommand == "Normal")
                {
                    Console.WriteLine($"Frogs: {string.Join(" ", frogs)}");
                }
                else if (subcommand == "Reversed")
                {
                    frogs.Reverse();
                    Console.WriteLine($"Frogs: {string.Join(" ", frogs)}");
                }
                break;
            }
        }
    }
}
