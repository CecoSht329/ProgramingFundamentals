using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int numberOfMessages = int.Parse(Console.ReadLine());
        List<string> attackedPlanets = new List<string>();
        List<string> destroyedPlanets = new List<string>();
        for (int i = 0; i < numberOfMessages; i++)
        {
            string message = Console.ReadLine();
            string letterPattern = "[S,T,A,R]|[s,t,a,r]";

            MatchCollection matches = Regex.Matches(message, letterPattern);
            StringBuilder decodedMessageBuilder = new StringBuilder();
            foreach (char symbol in message)
            {
                int currentCharAsNum = (int)(symbol);
                currentCharAsNum -= matches.Count;
                char currentChar = (char)(currentCharAsNum);
                decodedMessageBuilder.Append(currentChar);
            }
            string decodedMessage = decodedMessageBuilder.ToString();
            string messagePattern = @"[^@\-!:>]*@(?<planetName>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attackType>[A|D])[^@\-!:>]*![^@\-!:>]*-[^@\-!:>]*>(?<soldierCount>\d+)";
            Match match = Regex.Match(decodedMessage, messagePattern);
            if (match.Success)
            {
                string planetName = match.Groups["planetName"].Value;
                string attackType = match.Groups["attackType"].Value;
                if (attackType == "A")
                {
                    attackedPlanets.Add(planetName);
                }
                else
                {
                    destroyedPlanets.Add(planetName);
                }
            }
        }
        attackedPlanets.Sort();
        destroyedPlanets.Sort();
        Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
        PrintPresentPlanets(attackedPlanets);
        Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
        PrintPresentPlanets(destroyedPlanets);
    }

    private static void PrintPresentPlanets(List<string> planets)
    {
        for (int i = 0; i < planets.Count; i++)
        {
            Console.WriteLine($"-> {planets[i]}");
        }
    }
}

