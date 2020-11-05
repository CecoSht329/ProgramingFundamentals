using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int[] pirateship = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        int[] battleship = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        int maxHealth = int.Parse(Console.ReadLine());

        string input;
        while ((input = Console.ReadLine()) != "Retire")
        {
            string[] commands = input.Split(" ").ToArray();
            string command = commands[0];
            int index; int damage; int startIndex; int endIndex; int health; int count;

            if (command == "Fire")
            {
                index = int.Parse(commands[1]);
                damage = int.Parse(commands[2]);
                if (index >= 0 && index < battleship.Length)
                {
                    battleship[index] -= damage;
                    if (battleship[index] <= 0)//ship is broken
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return;
                    }
                }
            }
            else if (command == "Defend")
            {
                startIndex = int.Parse(commands[1]);
                endIndex = int.Parse(commands[2]);
                damage = int.Parse(commands[3]);
                if ((startIndex >= 0 && startIndex < pirateship.Length) && (endIndex >= 0 && endIndex < pirateship.Length))
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        pirateship[i] -= damage;
                        if (pirateship[i] <= 0)//ship is broken
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return;
                        }
                    }
                }
            }
            else if (command == "Repair")
            {
                index = int.Parse(commands[1]);
                health = int.Parse(commands[2]);
                if ((index >= 0 && index < pirateship.Length) && pirateship[index] <= maxHealth)
                {
                    pirateship[index] += health;
                    if (pirateship[index] > maxHealth)
                    {
                        pirateship[index] = maxHealth;
                    }
                }
            }
            else if (command == "Status")
            {
                count = 0;
                for (int i = 0; i < pirateship.Length; i++)
                {
                    if ((double)pirateship[i] < 0.2 * (double)maxHealth)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{count} sections need repair.");
            }
        }
        if (input == "Retire")
        {
            Console.WriteLine($"Pirate ship status: {pirateship.Sum()}");
            Console.WriteLine($"Warship status: {battleship.Sum()}");
        }
    }
}
