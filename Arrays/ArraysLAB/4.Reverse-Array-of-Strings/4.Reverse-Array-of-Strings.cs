using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] texts = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

        //texts = texts.Reverse().ToArray();-you can use this 
        //for (int i = 0; i < texts.Length; i++)
        //{
        //    Console.Write($"{texts[i]} ");
        //}
        for (int i = 0; i < texts.Length / 2; i++)//instead of this 
        { 
            string first = texts[i];
            string last = texts[texts.Length - i - 1];

            texts[i] = last;
            texts[texts.Length - i - 1] = first;
        }

        for (int i = 0; i < texts.Length; i++)
        {
            Console.Write($"{texts[i]} ");
        }
    }
}

