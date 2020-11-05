using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, long> resourceQuantity = new Dictionary<string, long>();

        string resource;
        while ((resource = Console.ReadLine()) != "stop")
        {

            int quantity = int.Parse(Console.ReadLine());
            if (!resourceQuantity.ContainsKey(resource))
            {
                resourceQuantity[resource] = 0;
            }
            resourceQuantity[resource] += quantity;
        }

        foreach (var kvp in resourceQuantity)
        {
            Console.WriteLine(kvp.Key + " -> " + kvp.Value);
        }
    }
}

