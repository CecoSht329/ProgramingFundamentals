using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegCount = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string isBiggest = string.Empty;
            for (int i = 0; i < kegCount; i++)
            {
                string currentKeg = Console.ReadLine();
                double radiusKeg = double.Parse(Console.ReadLine());
                int heightKeg = int.Parse(Console.ReadLine());

                double currentVolume = Math.PI * Math.Pow(radiusKeg, 2) * heightKeg;//this is the volume of the current keg
                if (currentVolume > biggestKeg)
                {
                    isBiggest = currentKeg;
                    biggestKeg = currentVolume;
                }
            }
            Console.WriteLine(isBiggest);
        }
    }
}
