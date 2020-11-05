using System;
using System.Linq;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        //BigInteger n = BigInteger.Parse(Console.ReadLine());
        //byte x = byte.Parse(Console.ReadLine());

        //Console.WriteLine(n * x);

        string numberAsString = Console.ReadLine();
        int multyplier = int.Parse(Console.ReadLine());
        StringBuilder builder = new StringBuilder();

        int remainder = 0;
        for (int i = numberAsString.Length - 1; i >= 0; i--)
        {
            int lastDigit = int.Parse(numberAsString[i].ToString());

            int result = lastDigit * multyplier + remainder;

            builder.Append(result % 10);
            remainder = result / 10;

        }
        if (remainder != 0)
        {
            builder.Append(remainder);
        }
        string resultNumber = string.Join("", builder.ToString().Reverse()).TrimStart('0');//TrimStart removes all zeros form start
        if (resultNumber == string.Empty)//in case the result is a zero
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(resultNumber);
        }
    }
}

