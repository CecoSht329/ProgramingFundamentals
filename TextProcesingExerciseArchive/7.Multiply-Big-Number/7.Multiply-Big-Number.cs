using System;
using System.Text;

class Program
{
    static void Main()
    {
        string num1 = Console.ReadLine();
        int multyplier = int.Parse(Console.ReadLine());

        //if (multyplier == 0)
        //{
        //    Console.WriteLine(0);
        //    return;
        //}

        //if (multyplier == 0)
        //{
        //    Console.WriteLine(0);
        //    Environment.Exit(0);
        //}
        StringBuilder result = new StringBuilder();
        int remainder = 0;
        bool isZero = false;
        for (int i = num1.Length - 1; i >= 0; i--)
        {
            if (multyplier == 0)
            {
                isZero = true;
                break;
            }
            int digit = int.Parse(num1[i].ToString());
            int currentSum = digit * multyplier + remainder;

            remainder = currentSum / 10;

            result.Append(currentSum % 10);
        }
        if (!isZero)
        {
            result.Append(remainder);
            string output = result.ToString().TrimEnd('0');
            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

