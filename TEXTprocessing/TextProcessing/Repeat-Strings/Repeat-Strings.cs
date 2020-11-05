using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        StringBuilder result = new StringBuilder();
        foreach (string word in words)
        {
            int count = word.Length;
            for (int i = 0; i < count; i++)
            {
                result.Append(word);
            }
        }
        Console.WriteLine(result);

        //for (int i = 0; i < words.Length; i++)
        //{
        //    string word = words[i];

        //    for (int j = 0; j < word.Length; j++)
        //    {
        //        Console.Write(word);
        //    }
        //}
    }
}

