using System;

namespace _6._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int openBracket = 0;
            int closingBracket = 0;
            for (int i = 1; i <= numberOfLines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    openBracket++;
                }
                else if (input == ")")
                {
                    closingBracket++;
                    if (openBracket - closingBracket != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            if (openBracket == closingBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else if (openBracket != closingBracket)
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
