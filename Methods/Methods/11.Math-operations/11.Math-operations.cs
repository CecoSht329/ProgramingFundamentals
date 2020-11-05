using System;


class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        char operation = char.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("="); 
        Console.WriteLine();
        Console.WriteLine(Calculate(firstNum, operation, secondNum));
    }
    static double Calculate(int firstNum, char operation, int secondNum)
    {
        int result = 0;
        switch (operation)
        {
            case '+':
                result = firstNum + secondNum;
                break;
            case '-':
                result = firstNum - secondNum;
                break;
            case '*':
                result = firstNum * secondNum;
                break;
            case '/':
                result = firstNum / secondNum;
                break;
        }
        return result;
    }
}

