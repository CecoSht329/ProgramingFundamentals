using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        //char[] inputArgs = input.ToCharArray();

        //inputArgs = inputArgs.Reverse().ToArray();

        //Console.WriteLine(string.Join("", inputArgs));
        Console.WriteLine(ReverseString(input));
    }
    public static string ReverseString(string word)
    {
        return string.Join("", word.ToCharArray().Reverse());
    }
}
