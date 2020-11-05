using System;


class Program
{
    static void Main()
    {
        string[] days = { "Monday", "Tuesday", "Wednsday", "Thursday", "Friday", "Saturday", "Sunday" };

        int input = int.Parse(Console.ReadLine());

        if (input <= 0 || input > 7)
        {
            Console.WriteLine("Invalid day!");
        }
        else
        {
            Console.WriteLine(days[input - 1]);
        }

    }
}

