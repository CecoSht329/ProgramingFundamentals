using System;

namespace UpperLowerCase
{
    class UpperLowerCase
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            if (char.IsLower(letter))
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
