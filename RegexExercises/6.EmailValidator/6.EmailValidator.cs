using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string pattern = @"(?<=\s)(?<user>[A-Za-z0-9]+[.-]*\w*)*@(?<host>[a-z]+?([.-][a-z]*)*(\.[a-z]{2,}))";

        MatchCollection matches = Regex.Matches(input, pattern);

        Console.WriteLine(string.Join(Environment.NewLine, matches));
    }
}

