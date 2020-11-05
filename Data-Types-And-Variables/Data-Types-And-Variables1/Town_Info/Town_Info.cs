using System;

namespace Town_Info
{
    class Town_Info
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int squareKilometers = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {town} has population of {population} and area {squareKilometers} square km.");
        }
    }
}
