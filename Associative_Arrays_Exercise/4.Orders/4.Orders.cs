using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, decimal> productPrices = new Dictionary<string, decimal>();
        Dictionary<string, long> productQuantity = new Dictionary<string, long>();

        string command;
        while ((command = Console.ReadLine()) != "buy")
        {
            string[] commandTokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string product = commandTokens[0];
            decimal price = decimal.Parse(commandTokens[1]);
            int quantity = int.Parse(commandTokens[2]);
            if (!productQuantity.ContainsKey(product))
            {
                productQuantity[product] = 0;
                productPrices[product] = 0;
            }
            productQuantity[product] += quantity;
            productPrices[product] = price;
        }

        foreach (var kvp in productQuantity)
        {
            string name = kvp.Key;
            long quantity = kvp.Value;
            decimal price = productPrices[name];
            decimal totalPrice = quantity * price;
            Console.WriteLine($"{name} -> {totalPrice:f2}");
        }
    }
}
