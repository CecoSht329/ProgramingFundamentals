using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine()
            .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        string text = Console.ReadLine();

        foreach (string word in words)
        {
            text = text.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}

