using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nCopy = n;
            int sum = 0;
            while (nCopy != 0)
            {
                int currentDigit = nCopy % 10;

                int currentFactorial = 1;
                for (int i = 1; i <= currentDigit; i++)
                {
                    currentFactorial *= i;
                }
                sum += currentFactorial;
                nCopy /= 10;
            }
            if (sum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
