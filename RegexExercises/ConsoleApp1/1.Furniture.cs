using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string regex = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

        List<string> items = new List<string>();
        double totalPrice = 0;

        string input;
        while ((input = Console.ReadLine()) != "Purchase")
        {
            Match match = Regex.Match(input, regex);
            if (match.Success)
            {
                string name = match.Groups["name"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);
                items.Add(name);
                totalPrice += price * quantity;
            }
        }
        Console.WriteLine($"Bought furniture:");
        if (items.Count > 0)
        {
            Console.WriteLine($"{string.Join(Environment.NewLine, items)}");
        }
        Console.WriteLine($"Total money spend: {totalPrice:f2}");
    }
}
