using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numberOfCommands = int.Parse(Console.ReadLine());

        Dictionary<string, string> registeredLicensePlates = new Dictionary<string, string>();

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] commandInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = commandInput[0];
            string name = commandInput[1];
            if (command == "register")
            {
                string licensePlateNumber = commandInput[2];
                if (!registeredLicensePlates.ContainsKey(name))
                {
                    registeredLicensePlates[name] = licensePlateNumber;
                    Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                }
            }
            else if (command == "unregister")
            {
                if (!registeredLicensePlates.ContainsKey(name))
                {
                    Console.WriteLine($"ERROR: user {name} not found");
                }
                else
                {
                    registeredLicensePlates.Remove(name);
                    Console.WriteLine($"{name} unregistered successfully");
                }
            }
        }
        foreach (var kvp in registeredLicensePlates)
        {
            Console.WriteLine(kvp.Key + " => " + kvp.Value);
        }
    }
}

