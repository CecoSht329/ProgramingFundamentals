using System;


class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());


        int firstResult = SmallerNumber(firstNum, secondNum);
        int smallestNumber = SmallerNumber(firstResult, thirdNum);
        Console.WriteLine(smallestNumber);
    }
    static int SmallerNumber(int firstNum, int secondNum)
    {
        if (firstNum < secondNum)
        {
            return firstNum;
        }
        return secondNum;
    }
}

