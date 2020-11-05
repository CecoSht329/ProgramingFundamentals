using System;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal length, width, height = 0;
            Console.Write("Length: ");
            length = decimal.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = decimal.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Pyramid Volume: {(length * width * height) / 3:f2}");
        }
    }
}
