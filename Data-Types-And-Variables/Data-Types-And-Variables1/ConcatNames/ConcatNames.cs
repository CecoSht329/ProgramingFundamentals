﻿using System;

namespace ConcatNames
{
    class ConcatNames
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimeter = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}", firstName, delimeter, lastName);
        }
    }
}
