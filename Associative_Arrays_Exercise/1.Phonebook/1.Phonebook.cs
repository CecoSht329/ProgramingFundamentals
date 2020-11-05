using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = inputArgs[0];
            string name = inputArgs[1];
            switch (command)
            {
                case "A":
                    string phone = inputArgs[2];
                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook[name] = string.Empty;
                    }
                    phoneBook[name] = phone;
                    break;
                case "S":
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " -> " + phoneBook[name]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    break;
            }
        }
    }
}

