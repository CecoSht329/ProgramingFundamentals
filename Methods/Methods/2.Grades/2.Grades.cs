using System;


class Program
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        PrintGrade(input);
    }
    static void PrintGrade(double input)
    {
        if (input >= 2 && input <= 2.99)
        {
            Console.WriteLine("Fail");
        }
        else if (input >= 3 && input <= 3.49)
        {
            Console.WriteLine("Poor");

        }
        else if (input >= 3.5 && input <= 4.49)
        {
            Console.WriteLine("Good");

        }
        else if (input >= 4.5 && input <= 5.49)
        {
            Console.WriteLine("Very good");

        }
        else
        {
            Console.WriteLine("Excellent");

        }
    }
}

