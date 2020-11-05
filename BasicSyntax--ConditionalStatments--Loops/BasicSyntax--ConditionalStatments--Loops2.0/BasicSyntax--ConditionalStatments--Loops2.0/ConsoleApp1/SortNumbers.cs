using System;

namespace ConsoleApp1
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int x = 0;

            if (b < a)
            {
                x = a;
                a = b;
                b = x;
            }
            if (c < a)
            {
                x = c;
                c = a;
                a = x;
            }
            if (c < b)
            {
                x = c;
                c = b;
                b = x;
            }
            if (a == b)
            {
                x = a;
                a = b;
                b = x;
            }
            if (a == c)
            {
                x = a;
                a = c;
                c = x;
            }
            if (b == c)
            {
                x = b;
                b = c;
                c = x;
            }
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }
}

