using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Regex regex = new Regex(@"\|<(?<picture>\w+)");

        int skipNums = nums[0];
        int takeNums = nums[1];

        string txt = Console.ReadLine();

        MatchCollection matches = regex.Matches(txt);

        string[] allResults = new string[matches.Count];
        int index = 0;
        foreach (Match match in matches)
        {
            string currentmatch = match.Groups["picture"].Value;
            char[] currentmatchToArray = currentmatch.Skip(skipNums).Take(takeNums).ToArray();

            string currentResult = string.Join("", currentmatchToArray);
            allResults[index++] = currentResult;
        }
        Console.WriteLine(string.Join(", ", allResults));
    }
}

