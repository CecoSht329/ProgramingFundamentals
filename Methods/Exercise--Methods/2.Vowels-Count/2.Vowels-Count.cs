using System;
using System.Linq;


class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        CountTheVowels(word);
    } 
    static void CountTheVowels(string word)
    {
        string vowels = "aAeEiIoOuU";
        char[] vowelArr = vowels.ToCharArray();
        int vowelCount = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (vowelArr.Contains(word[i]))
            {
                vowelCount++;
            }
        }
        Console.WriteLine(vowelCount);
    }

}

