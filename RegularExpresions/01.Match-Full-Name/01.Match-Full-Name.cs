using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
        //Regex regex = new Regex(pattern);

        string input = Console.ReadLine();

        //MatchCollection matches = regex.Matches(input);

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match item in matches)
        {
            Console.Write($"{item.Value} ");
        }
    }
}

