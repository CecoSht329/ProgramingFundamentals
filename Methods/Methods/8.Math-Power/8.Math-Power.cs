using System;


class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());
        Console.WriteLine(CalculatePower(number, power));
    }

    static double CalculatePower(double number, double power)
    {
        return Math.Pow(number, power);
    }

}

