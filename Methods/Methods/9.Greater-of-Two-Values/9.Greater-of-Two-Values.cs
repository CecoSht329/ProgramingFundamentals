using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        string valueType = Console.ReadLine().ToLower();
        if (valueType == "int")
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxNumber = GetMaxInt(firstNumber, secondNumber);
            Console.WriteLine(maxNumber);
        }
        else if (valueType == "char")
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            int maxChar = GetMaxChar(firstChar, secondChar);
            Console.WriteLine(maxChar);
        }
        else if (valueType == "string")
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            string maxString = GetMaxString(firstString, secondString);
            Console.WriteLine(maxString);
        }
    }
    static int GetMaxInt(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
    static char GetMaxChar(char firstChar, char secondChar)
    {
        if (firstChar > secondChar)
        {
            return firstChar;
        }
        else
        {
            return secondChar;
        }
    }
    static string GetMaxString(string firstString, string secondString)
    {
        if (firstString.CompareTo(secondString) >= 0)
        {
            return firstString;
        }
        else
        {
            return secondString;
        }
    }
}

