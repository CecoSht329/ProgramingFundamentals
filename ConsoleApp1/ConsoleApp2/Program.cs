using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex treasureValidator = new Regex(@"(&)(?<treasure>[a-zA-z]+)\1");
            Regex coordinatesValdator = new Regex(@"<(?<coordinates>[a-zA-Z0-9]+)>");


            int[] keySequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            string input = "";
            while ((input = Console.ReadLine()) != "find")
            {
                int counter = 0;
                StringBuilder sb = new StringBuilder();
                foreach (char symbol in input)
                {
                    int symbolToInt = (int)(symbol);
                    symbolToInt -= keySequence[counter];
                    sb.Append((char)(symbolToInt));
                    counter++;
                    if (counter == keySequence.Length)
                    {
                        counter = 0;
                    }
                }
                string message = sb.ToString();
                Match treasureMatch = treasureValidator.Match(message);
                Match coordinatesMatch = coordinatesValdator.Match(message);
                string treasure = treasureMatch.Groups["treasure"].Value;
                string coordiantes = coordinatesMatch.Groups["coordinates"].Value;
                Console.WriteLine($"Found {treasure} at {coordiantes}");
            }
        }
    }
}
