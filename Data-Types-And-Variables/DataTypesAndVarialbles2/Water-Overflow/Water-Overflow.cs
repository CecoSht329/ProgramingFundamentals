using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//the number of lines, which will follow

            int sumLitters = 0;
            for (int i = 0; i < n; i++)
            {
                int currentLitters = int.Parse(Console.ReadLine());//this is the litters pured in to the tank
                sumLitters += currentLitters;
                if (sumLitters > 255)
                {
                    sumLitters -= currentLitters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sumLitters);
        }
    }
}
