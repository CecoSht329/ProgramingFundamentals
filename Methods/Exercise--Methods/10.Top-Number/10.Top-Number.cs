using System;


class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        PrintTheNumbers(number);
    }
    static void PrintTheNumbers(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            if (DoesItHaveAnOddDigit(i) && IsDigitDivisibleByEight(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool DoesItHaveAnOddDigit(int number)
    {
        while (number > 0)
        {
            if ((number % 10) % 2 == 1)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
    static bool IsDigitDivisibleByEight(int number)
    {
        int digitSum = 0;
        while (number > 0)
        {
            digitSum += number % 10;
            number /= 10;
        }
        if (digitSum % 8 == 0)
        {
            return true;
        }
        return false;
    }
}

