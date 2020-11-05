using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int wagonCount = int.Parse(Console.ReadLine());
        int[] train = new int[wagonCount];
        //int sum = 0;
        for (int i = 0; i < wagonCount; i++)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            //sum += numberOfPeople;----------of this

            train[i] = numberOfPeople;
        }
        int sum = train.Sum();//You can do this insted
        Console.WriteLine(string.Join(" ", train));
        Console.WriteLine(sum);
    }
}

