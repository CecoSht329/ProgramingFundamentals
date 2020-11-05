using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfInfo = new Dictionary<string, int>();

            string input = "";
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

                string dwarf = tokens[0];
                string color = tokens[1];
                int physics = int.Parse(tokens[2]);

                string ID = dwarf + ":" + color;
                if (!dwarfInfo.ContainsKey(ID))
                {
                    dwarfInfo.Add(ID, physics);
                }
                else
                {
                    dwarfInfo[ID] = Math.Max(dwarfInfo[ID], physics);
                }
            }
            
            foreach (var dwarf in dwarfInfo
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfInfo.Where(y => y.Key.Split(":")[1] == x.Key.Split(":")[1])
                .Count()))
            {
                Console.WriteLine($"({dwarf.Key.Split(":")[1]}) {dwarf.Key.Split(":")[0]} <-> {dwarf.Value}");
            }
        }
    }
}