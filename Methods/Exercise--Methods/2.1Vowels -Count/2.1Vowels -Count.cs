using System;


class Program
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();

        int result = GetVowelsCount(word);
        Console.WriteLine(result);
    }

    static int GetVowelsCount(string word)
    {
        string vowels = "aeiou";
        int counter = 0;
        for (int i = 0; i < word.Length; i++)
        {
            char currSymbol = word[i];
            if (vowels.Contains(currSymbol))
            {
                counter++;
            }

        }

        return counter;
    }
}

