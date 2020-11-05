using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Dictionary<string, int> childAmountOfPresents = new Dictionary<string, int>();
        Dictionary<string, int> toyAmount = new Dictionary<string, int>();

        string input = "";
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            string[] tokens = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
            string childName = tokens[0];
            string typeOfPresent = tokens[1];
            int amount = int.Parse(tokens[2]);

            if (!childAmountOfPresents.ContainsKey(childName))
            {
                childAmountOfPresents[childName] = 0;
            }
            childAmountOfPresents[childName] += amount;
            if (!toyAmount.ContainsKey(typeOfPresent))
            {
                toyAmount[typeOfPresent] = 0;
            }
            toyAmount[typeOfPresent] += amount;
        }
        Console.WriteLine("Children:");
        foreach (var kvp in childAmountOfPresents)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}

