using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Regex regex = new Regex(@"\b(?:0x)?[0-9A-F]+\b");


        MatchCollection matches = regex.Matches(input);

        string[] numbers = matches
               .Cast<Match>()
               .Select(a => a.Value)
               .ToArray();
        Console.WriteLine(string.Join(" ", numbers));
    }
}

