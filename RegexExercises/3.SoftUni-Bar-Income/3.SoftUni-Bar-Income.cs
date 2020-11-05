using System;
using System.Text.RegularExpressions;

namespace _3.SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[0-9]*\.?[0-9]+)\$$";
            //tricky part [^|$%.]*-meaning: anything  except ('|', '$', '%'  '.')
            decimal totalIncome = 0;
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal currentTotalPrice = price * count;
                    totalIncome += currentTotalPrice;
                    Console.WriteLine($"{customer}: {product} - {currentTotalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
