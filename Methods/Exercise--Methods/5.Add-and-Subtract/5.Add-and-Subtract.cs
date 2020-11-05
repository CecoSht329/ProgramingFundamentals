using System;


class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        int sumFirstAndSecond = NewMethod(firstNum, secondNum);
        int result = Subtract(thirdNum, sumFirstAndSecond);

        PrintResult(result);
    }

    private static void PrintResult(int result)
    {
        Console.WriteLine(result);
    }

    private static int Subtract(int thirdNum, int sumFirstAndSecond)
    {
        return sumFirstAndSecond - thirdNum;
    }

    private static int NewMethod(int firstNum, int secondNum)
    {
        return firstNum + secondNum;
    }
}

