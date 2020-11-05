using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string pattern = @"\+359([\s|-])2\1[0-9]{3}\1[0-9]{4}\b";

        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(input);

        string[] matchedPhones = matches
             .Cast<Match>()
             .Select(a => a.Value)
             .ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));
        //int counter = 0;
        //foreach (Match item in matches)
        //{
        //    counter++;
        //    if (counter == matches.Count)
        //    {
        //        Console.Write(item.Value);
        //    }
        //    else
        //    {
        //        Console.Write(item.Value + ", ");
        //    }
        //}
    }
}

