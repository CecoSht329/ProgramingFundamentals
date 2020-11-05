using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class RgularExpresions
{
    static void Main()
    {
        Regex regex = new Regex(@"(?<surround>\||#)(?<item>[A-Za-z\s]+)\1(?<day>\d{2})\/(?<month>\d{2})\/(?<year>\d{2})\1(?<calories>\d+)\1");

        string input = Console.ReadLine();

        MatchCollection matches = regex.Matches(input);
        int caloriesNeeded = 2000;
        int totalCalories = 0;
        List<string> itemInfo = new List<string>();
        foreach (Match match in matches)
        {
            int calories = int.Parse(match.Groups["calories"].Value);
            totalCalories += calories;
        }
        int daysToLast = totalCalories / caloriesNeeded;
        Console.WriteLine($"You have food to last you for: {daysToLast} days!");

        foreach (Match match in matches)
        {
            string item = match.Groups["item"].Value;
            string day = match.Groups["day"].Value;
            string month = match.Groups["month"].Value;
            string year = match.Groups["year"].Value;
            string calories = match.Groups["calories"].Value;
            Console.WriteLine($"Item: {item}, Best before: {day}/{month}/{year}, Nutrition: {calories}");
        }
    }
}

