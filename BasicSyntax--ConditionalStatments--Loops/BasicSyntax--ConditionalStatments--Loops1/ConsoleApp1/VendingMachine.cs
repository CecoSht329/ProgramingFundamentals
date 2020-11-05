using System;

namespace ConsoleApp1
{
    class VendingMachine
    {
        static void Main(string[] args)
        {
            string inputCoins = Console.ReadLine();
            double sumMoney = 0;
            while (inputCoins != "Start")
            {
                double money = double.Parse(inputCoins);
                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {
                    sumMoney += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                inputCoins = Console.ReadLine();
            }
            string product = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            while (product != "End")
            {
                if (product == "Nuts")
                {
                    price = 2.0;
                    if (sumMoney >= price)
                    {
                        sumMoney -= price;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    price = 0.7;
                    if (sumMoney >= price)
                    {
                        sumMoney -= price;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    price = 1.5;
                    if (sumMoney >= price)
                    {
                        sumMoney -= price;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    price = 0.8;
                    if (sumMoney >= price)
                    {
                        sumMoney -= price;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    price = 1.0;
                    if (sumMoney >= price)
                    {
                        sumMoney -= price;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        totalPrice += price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }
            if (sumMoney > 0)
            {
                Console.WriteLine($"Change: {sumMoney:f2}");
            }
            else
            {
                Console.WriteLine("Change: 0.00");
            }
        }
    }
}
