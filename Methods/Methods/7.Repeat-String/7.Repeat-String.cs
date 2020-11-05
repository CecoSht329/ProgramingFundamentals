using System;


class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        string result = Repeat(text, count);
        Console.WriteLine(result);
    }
    static string Repeat(string text, int count)
    {
        string result = string.Empty;

        for (int i = 0; i < count; i++)
        {
            result += text;
        }
        return result;
    }
}

