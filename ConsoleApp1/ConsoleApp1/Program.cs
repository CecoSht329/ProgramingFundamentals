using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestUsernamePoints = new
                 Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individualStanding = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string username = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);
                bool itMustSum = false;

                if (!contestUsernamePoints.ContainsKey(contest))
                {
                    contestUsernamePoints[contest] = new Dictionary<string, int>();
                    contestUsernamePoints[contest][username] = points;
                    itMustSum = true;
                }
                else
                {
                    if (!contestUsernamePoints[contest].ContainsKey(username))
                    {
                        contestUsernamePoints[contest][username] = points;
                        itMustSum = true;
                    }
                    else
                    {
                        int currentPoints = contestUsernamePoints[contest][username];
                        if (currentPoints < points)
                        {
                            contestUsernamePoints[contest][username] = points;
                            points -= currentPoints;// Тук вадя от новите точки старите за да получа само разликата, която по-късно да добавя в usersTotalPoint
                            itMustSum = true;
                        }
                    }
                }
                if (!individualStanding.ContainsKey(username))
                {
                    individualStanding[username] = 0;
                }
                // Добавям точките в втория речник, само ако е изпълнено условието при горните проверки т.е. itMustSum е true
                if (itMustSum)
                {
                    individualStanding[username] += points;
                }
            }

            foreach (var pair in contestUsernamePoints)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count()} participants");
                int counter = 1;
                foreach (var kvp in pair.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter}. {kvp.Key} <::> {kvp.Value}");
                    counter++;
                }
            }
            Console.WriteLine($"Individual standings:");
            int counterForUsers = 1;
            foreach (var kvp in individualStanding
               .OrderByDescending(x => x.Value)
               .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{counterForUsers}. {kvp.Key} -> {kvp.Value}");
                counterForUsers++;
            }
        }
    }
}
