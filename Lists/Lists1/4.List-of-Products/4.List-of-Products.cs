using System;
using System.Linq;
using System.Collections.Generic;

class ListofProducts
{
    static void Main()
    {
        int productCount = int.Parse(Console.ReadLine());
        List<string> products = new List<string>();

        for (int i = 0; i < productCount; i++)
        {
            string currentProduct = Console.ReadLine();
            products.Add(currentProduct);
        }
        products.Sort();

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i+1}.{products[i]}");
        }
    }
}

