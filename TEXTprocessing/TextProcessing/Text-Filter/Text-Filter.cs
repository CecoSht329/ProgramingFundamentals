using System;


class Program
{
    static void Main(string[] args)
    {
        string[] wordsToBan = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();


        for (int i = 0; i < wordsToBan.Length; i++)
        {
            string wordToCensure = wordsToBan[i];

            while (text.Contains(wordToCensure))
            {
                text = text.Replace(wordToCensure, new string('*', wordToCensure.Length));
            }
        }
        Console.WriteLine(text);

    }
}

