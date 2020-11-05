using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string[] words = Console.ReadLine()
            .Split("!?., ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);


        List<string> palindromes = new List<string>();

        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }
        Console.WriteLine(string.Join(", ", palindromes
            .OrderBy(x => x)
            .Distinct()));
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);

        //for (int i = 0; i < words.Length; i++)
        //{
        //    bool isPalindrome = true;
        //    char[] word = words[i].ToArray();
        //    char[] reversedWord = word.Reverse().ToArray();
        //    for (int j = 0; j < word.Length; j++)
        //    {
        //        if (word[j] != reversedWord[j])
        //        {
        //            isPalindrome = false;
        //            break;
        //        }
        //    }
        //    if (isPalindrome)
        //    {
        //        string palindrome = string.Join("", word);
        //        palindromes.Add(palindrome);
        //    }
        //}
        //palindromes.Sort();
        //Console.WriteLine(string.Join(", ", palindromes.Distinct()));

    }

    private static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}

