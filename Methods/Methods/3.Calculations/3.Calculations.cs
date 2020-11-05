using System;


class Program
{
    static void Main()
    {
        string operationType = Console.ReadLine();
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        switch (operationType)
        {
            case "add":
                Add(firstNum, secondNum);
                break;
            case "subtract":
                Subtract(firstNum, secondNum);
                break;
            case "multiply":
                Multiply(firstNum, secondNum);
                break;
            case "divide":
                Divide(firstNum, secondNum);
                break;
        }
    }
    static void Add(int firstNum, int secondNum)
    {
        Console.WriteLine(firstNum + secondNum);
    }
    static void Subtract(int firstNum, int secondNum)
    {
        Console.WriteLine(firstNum - secondNum);
    }
    static void Multiply(int firstNum, int secondNum)
    {
        Console.WriteLine(firstNum * secondNum);

    }
    static void Divide(int firstNum, int secondNum)
    {
        Console.WriteLine(firstNum / secondNum);

    }
}

