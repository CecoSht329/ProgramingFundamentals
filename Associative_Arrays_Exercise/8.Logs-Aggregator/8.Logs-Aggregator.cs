using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        SortedDictionary<string, int> userLogins = new SortedDictionary<string, int>();
        SortedDictionary<string, List<string>> userIPs = new SortedDictionary<string, List<string>>();

        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string ipAdress = tokens[0];
            string userName = tokens[1];
            int logins = int.Parse(tokens[2]);

            if (!userLogins.ContainsKey(userName))
            {
                userLogins[userName] = 0;
            }
            userLogins[userName] += logins;

            if (!userIPs.ContainsKey(userName))
            {
                userIPs[userName] = new List<string>();
            }
            userIPs[userName].Add(ipAdress);
        }


        foreach (KeyValuePair<string, int> kvp in userLogins)
        {
            Console.Write($"{kvp.Key}: {kvp.Value}");
            foreach (var pair in userIPs)
            {
                pair.Value.Sort();
                List<string> sorted = pair.Value.Distinct().ToList();
                if (kvp.Key == pair.Key)
                {
                    Console.Write($" [{string.Join(", ", sorted)}]");
                }
            }
            Console.WriteLine();
        }
    }
}

