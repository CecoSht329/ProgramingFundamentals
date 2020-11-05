using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (!wordsDictionary.ContainsKey(word))
            {
                wordsDictionary[word] = 0;
            }
            wordsDictionary[word]++;
        }

        var wordList = wordsDictionary
            .Where(w => w.Value % 2 == 1)
            .Select(w => w.Key)
            .ToList();

        Console.WriteLine(string.Join(" ", wordList));
    }
}
