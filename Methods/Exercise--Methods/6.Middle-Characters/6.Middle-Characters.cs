using System;


class Program
{
    static void Main()
    {
        string word = Console.ReadLine();

        GetResult(word);
    }

    private static void GetResult(string word)
    {
        int left = 0;
        int right = word.Length;
        for (int i = 0; i <= word.Length; i++)
        {
            if (word.Length % 2 == 0)
            {
                if (left == right)
                {
                    Console.WriteLine($"{word[i - 1]}{word[i]}");
                }
            }
            else
            {
                if (left + 1 == right)
                {
                    Console.WriteLine(word[i]);
                }
            }

            left++;
            right--;

        }
    }
}

