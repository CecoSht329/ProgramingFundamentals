using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

class Program
{
    static void Main()
    {

        Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
        keyMaterials["motes"] = 0;
        keyMaterials.Add("fragments", 0);
        keyMaterials.Add("shards", 0);
        Dictionary<string, int> junk = new Dictionary<string, int>();
        bool isObtained = false;
        while (true)
        {
            string[] quantities = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int quantity = 0;
            string material = string.Empty;
            for (int i = 0; i < quantities.Length; i++)
            {
                if (i % 2 == 0)//quntities[i] is number  else it is the material
                {
                    quantity = int.Parse(quantities[i]);
                }
                else
                {
                    material = quantities[i].ToLower();
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (!keyMaterials.ContainsKey(material))
                        {
                            keyMaterials[material] = 0;
                        }
                        keyMaterials[material] += quantity;
                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            isObtained = true;
                            switch (material)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = 0;
                        }
                        junk[material] += quantity;
                    }
                }
            }
            if (isObtained)
            {
                Dictionary<string, int> filteredKeyMaterials = keyMaterials
                 .OrderByDescending(kvp => kvp.Value)
                 .ThenBy(kvp => kvp.Key)
                 .ToDictionary(a => a.Key, a => a.Value);
                foreach (var kvp in filteredKeyMaterials)
                {
                    material = kvp.Key;
                    quantity = kvp.Value;
                    Console.WriteLine($"{material}: {quantity}");
                }
                foreach (var kvp in junk.OrderBy(kvp => kvp.Key))
                {
                    material = kvp.Key;
                    quantity = kvp.Value;
                    Console.WriteLine($"{material}: {quantity}");
                }
                break;
            }
        }
    }
}

