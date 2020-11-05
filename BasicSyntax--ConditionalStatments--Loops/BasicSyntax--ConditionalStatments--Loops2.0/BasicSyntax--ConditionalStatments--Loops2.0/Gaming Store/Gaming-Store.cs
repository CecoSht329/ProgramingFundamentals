using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal currentBalance = decimal.Parse(Console.ReadLine());
            decimal spend = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Game Time")
                {
                    break;
                }

                decimal price = 0;
                switch (input)
                {
                    case "OutFall 4": price = 39.99m; break;
                    case "CS: OG": price = 15.99m; break;
                    case "Zplinter Zell": price = 19.99m; break;
                    case "Honored 2": price = 59.99m; break;
                    case "RoverWatch": price = 29.99m; break;
                    case "RoverWatch Origins Edition": price = 39.99m; break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (price > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                  
                }
                currentBalance -= price;
                spend += price;
                Console.WriteLine($"Bought {input}");
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${spend:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
