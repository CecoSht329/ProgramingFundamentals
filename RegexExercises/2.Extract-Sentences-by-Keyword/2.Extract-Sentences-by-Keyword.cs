using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string searchWord = Console.ReadLine();

        string pattern = $@"\b{searchWord}\b";
        Regex regex = new Regex(pattern);

        string[] words = Console.ReadLine()
            .Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
           

        foreach (string word in words)
        {
            if (regex.IsMatch(word))
            {
                Console.WriteLine(word.Trim());
            }
        }
    }
}

