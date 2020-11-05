using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;

class Program
{
    static void Main()
    {
        // tricky part here is getting the right index + swap commands
        List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

        string input;
        while ((input = Console.ReadLine()) != "Stop")
        {
            string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = commands[0];
            int index; string word; string word1; string word2;
            switch (command)
            {
                case "Delete":
                    index = int.Parse(commands[1]);
                    int wantedIndex = index + 1;//this is the corrext index
                    if (wantedIndex >= 0 && wantedIndex < words.Count)
                    {
                        words.RemoveAt(wantedIndex);
                    }
                    break;
                case "Swap"://an other way to swap
                    word1 = commands[1];
                    word2 = commands[2];
                    if (words.Contains(word1) && words.Contains(word2))
                    {
                        int index1 = words.IndexOf(word1);
                        int index2 = words.IndexOf(word2);
                        words.RemoveAt(index1);
                        words.Insert(index1, word2);
                        words.RemoveAt(index2);
                        words.Insert(index2, word1);
                    }
                    break;
                case "Put"://also gettting the right index
                    word = commands[1];
                    index = int.Parse(commands[2]);
                    wantedIndex = index - 1;
                    if (wantedIndex >= 0 && wantedIndex <= words.Count)
                    {
                        words.Insert(wantedIndex, word);
                    }
                    break;
                case "Sort"://this is how you sort a list in discending order
                    words.Sort((x, y) => y.CompareTo(x));
                    break;
                case "Replace"://also good way to swap
                    word1 = commands[1];
                    word2 = commands[2];
                    if (words.Contains(word2))
                    {
                        int indexWord2 = words.IndexOf(word2);
                        words.Remove(word2);
                        words.Insert(indexWord2, word1);
                    }
                    break;
            }
        }
        Console.WriteLine(string.Join(" ", words));
    }
}
