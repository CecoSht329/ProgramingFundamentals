using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = inputArgs[0];

            switch (command)
            {
                case "A":
                    string name = inputArgs[1];
                    string phone = inputArgs[2];
                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook[name] = string.Empty;
                    }
                    phoneBook[name] = phone;
                    break;
                case "S":
                    name = inputArgs[1];
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " -> " + phoneBook[name]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    break;
                case "ListAll":
                    //phoneBook = phoneBook
                    //    .OrderBy(x => x.Key)
                    //    .ToDictionary(x => x.Key, x => x.Value);
                    foreach (var kvp in phoneBook)
                    {
                        Console.WriteLine(kvp.Key + " -> " + kvp.Value);
                    }
                    break;
            }
        }
    }
}

