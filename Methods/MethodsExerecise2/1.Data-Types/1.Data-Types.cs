using System;


class Program
{
    static void Main()
    {
        string dataType = Console.ReadLine();
        double result = 0;
        if (dataType == "int")
        {
            result = GetNumber(dataType, result);
            Console.WriteLine(result);

        }
        if (dataType == "real")
        {
            result = GetNumber(dataType, result);
            Console.WriteLine($"{result:f2}");
        }
        if (dataType == "string")
        {
            string input = Console.ReadLine();
            Console.WriteLine($"${input}$");
        }

    }

    private static double GetNumber(string dataType, double result)
    {
        if (dataType == "int")
        {
            int input = int.Parse(Console.ReadLine());
            result = input * 2;
        }
        else if (dataType == "real")
        {
            double input = double.Parse(Console.ReadLine());
            result = input * 1.5;
        }

        return result;
    }
}

