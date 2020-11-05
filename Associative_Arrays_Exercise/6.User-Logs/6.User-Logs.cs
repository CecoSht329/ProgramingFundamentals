using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //Create Dictionary<string,Dictionary<string,List<string>>>
        //Read Input until end command
        //Process Input
        //add to data to dictionary - should look like this Dictionary<user,Dictionary<IP,List<messeges>>>
        //Print Result

        SortedDictionary<string, Dictionary<string, List<string>>> userIpMesseges = new
            SortedDictionary<string, Dictionary<string, List<string>>>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] inputArgs = input.Split(" ");
            string[] ipTxt = inputArgs[0].Split("=");
            string ip = ipTxt[1];
            string message = inputArgs[1];
            string[] userTxt = inputArgs[2].Split("=");
            string user = userTxt[1];
            if (!userIpMesseges.ContainsKey(user))
            {
                userIpMesseges[user] = new Dictionary<string, List<string>>();
            }
            if (!userIpMesseges[user].ContainsKey(ip))
            {
                userIpMesseges[user][ip] = new List<string>();
            }
            userIpMesseges[user][ip].Add(message);
        }

        foreach (var kvp in userIpMesseges)
        {
            Console.WriteLine($"{kvp.Key}:");
            var list = kvp.Value;
            int count = list.Count;
            foreach (var keyValuePair in kvp.Value)
            {
                count--;
                if (count > 0)
                {
                    Console.Write($"{keyValuePair.Key} => {keyValuePair.Value.Count}, ");
                }
                else
                {
                    Console.Write($"{keyValuePair.Key} => {keyValuePair.Value.Count}. ");
                }
            }
            Console.WriteLine();
        }
    }
}

