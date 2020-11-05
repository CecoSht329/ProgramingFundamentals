using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numChar = uint.Parse(Console.ReadLine());
            int sum = 0;
            for (int counter = 0; counter < numChar; counter++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum +=(int)letter;
            }
            Console.WriteLine("The sum equals: {0}",sum);
        }
    }
}
