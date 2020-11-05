using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Dictionary<string, int> results = new Dictionary<string, int>();
        Dictionary<string, int> submissions = new Dictionary<string, int>();//language- count

        string input;
        while ((input = Console.ReadLine()) != "exam finished")
        {
            string[] inputArguments = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
            string username = string.Empty;
            if (!input.Contains("banned"))
            {
                username = inputArguments[0];
                string language = inputArguments[1];
                int points = int.Parse(inputArguments[2]);
                if (!results.ContainsKey(username))
                {
                    results[username] = 0;
                }
                if (points > results[username])
                {
                    results[username] = points;
                }
                if (!submissions.ContainsKey(language))
                {
                    submissions[language] = 0;
                }
                submissions[language]++;
            }
            else
            {
                username = inputArguments[0];
                if (results.ContainsKey(username))
                {
                    results.Remove(username);
                }
            }
        }
        Console.WriteLine("Results:");
        var orderedResults = results
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);
        foreach (var kvp in orderedResults)
        {
            Console.WriteLine($"{kvp.Key} | {kvp.Value}");
        }
        Console.WriteLine("Submissions:");
        var orderedSubmissions = submissions
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);
        foreach (var kvp in orderedSubmissions)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }
    }
}