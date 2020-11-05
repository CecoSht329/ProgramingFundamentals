using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        SortedDictionary<string, int> sentMessages = new SortedDictionary<string, int>();
        SortedDictionary<string, int> recievedMessages = new SortedDictionary<string, int>();


        int maxMessageCapacity = int.Parse(Console.ReadLine());

        string line = "";
        while ((line = Console.ReadLine()) != "Statistics")
        {
            string[] tokens = line.Split("=", StringSplitOptions.RemoveEmptyEntries);

            string command = tokens[0];
            string name = tokens[1];

            if (command == "Add")
            {
                int sent = int.Parse(tokens[2]);
                int recieved = int.Parse(tokens[3]);

                if (!recievedMessages.ContainsKey(name) && !sentMessages.ContainsKey(name))
                {
                    sentMessages[name] = 0;
                    recievedMessages[name] = 0;
                    sentMessages[name] = sent;
                    recievedMessages[name] = recieved;
                }
                else
                {
                    continue;
                }
            }
            else if (command == "Message")
            {
                string sender = name;
                string reciever = tokens[2];
                if (sentMessages.ContainsKey(sender) && recievedMessages.ContainsKey(sender)
                    && sentMessages.ContainsKey(reciever) && recievedMessages.ContainsKey(reciever))
                {
                    sentMessages[sender]++;
                    recievedMessages[reciever]++;
                    if (sentMessages[sender] + recievedMessages[sender] >= maxMessageCapacity)
                    {
                        sentMessages.Remove(sender);
                        recievedMessages.Remove(sender);
                        Console.WriteLine($"{sender} reached the capacity!");
                    }
                    if (sentMessages[reciever] + recievedMessages[reciever] >= maxMessageCapacity)
                    {
                        sentMessages.Remove(reciever);
                        recievedMessages.Remove(reciever);
                        Console.WriteLine($"{reciever} reached the capacity!");
                    }
                }
            }
            else if (command == "Empty")
            {
                if (name == "All")
                {
                    sentMessages = new SortedDictionary<string, int>();
                    recievedMessages = new SortedDictionary<string, int>();
                }
                else
                {
                    if (sentMessages.ContainsKey(name))
                    {
                        sentMessages.Remove(name);
                        recievedMessages.Remove(name);
                    }
                }
            }
        }
        Console.WriteLine($"Users count: {sentMessages.Count}");
        foreach (var pair in recievedMessages.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{pair.Key} - {pair.Value + sentMessages[pair.Key]}");
        }
    }
}