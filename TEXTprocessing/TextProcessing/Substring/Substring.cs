using System;


class Substring
{
    static void Main(string[] args)
    {
        string wordToRemove = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();

        while (text.Contains(wordToRemove))
        {
            int startIndex = text.IndexOf(wordToRemove);
            text = text.Remove(startIndex, wordToRemove.Length);
        }
        Console.WriteLine(text);

        //    string key = Console.ReadLine().ToLower();
        //    string text = Console.ReadLine();

        //    int index = text.IndexOf(key);

        //    while (index != -1)//if index not found index=-1 always
        //    {
        //        text = text.Remove(index, key.Length);
        //        index = text.IndexOf(key);
        //    }
        //    Console.WriteLine(text);
    }
}
