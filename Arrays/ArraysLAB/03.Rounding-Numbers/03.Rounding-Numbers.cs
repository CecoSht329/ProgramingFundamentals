using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
        int[] roundNums = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            double number = numbers[i];
            //ТОВА E ЗА ЗАКРЪГЛЯНЕ КЪМ ЦЯЛО ЧИСЛО ↓
            double roundNum = Math.Round(number, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{Convert.ToDecimal(number)} => {Convert.ToDecimal(roundNum)}");
        }
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => " +
        //        $"{Math.Round(Convert.ToDecimal(numbers[i]), MidpointRounding.AwayFromZero)}");
        //}
    }
}

