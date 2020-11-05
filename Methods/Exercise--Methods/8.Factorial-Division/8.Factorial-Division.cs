using System;


class Program
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        PrintDivisionResult(firstNumber, secondNumber);
    }

    static void PrintDivisionResult(double firstNumber, double secondNumber)
    {
        double result = GetFactorialFirstNum(firstNumber) / GetFactorialSecondNum(secondNumber);
        Console.WriteLine($"{result:f2}");
    }

    static double GetFactorialFirstNum(double firstNumber)
    {
        if (firstNumber == 1)
        {
            return 1;
        }
        return firstNumber * GetFactorialFirstNum(firstNumber - 1);
    }
    static double GetFactorialSecondNum(double firstNumber)
    {
        if (firstNumber == 1)
        {
            return 1;
        }
        return firstNumber * GetFactorialSecondNum(firstNumber - 1);
    }
}

