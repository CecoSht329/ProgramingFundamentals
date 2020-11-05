using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string txt = Console.ReadLine();
        
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < txt.Length; i++)
        {
            char currentSymbol = txt[i];
            int neededSymbol = txt[i] + 3;
            result.Append((char)(neededSymbol));
        }
        Console.WriteLine(result);
    }
}

