using System;
class Program
{
    static void Main()
    {
        int countNumbers = int.Parse(Console.ReadLine());
        for (int number = 2; number <= countNumbers; number++)
        {
            bool isPrime = true;
            for (int divider = 2; divider < number; divider++)
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine($"{number} -> true");
            }
            else
            {
                Console.WriteLine($"{number} -> false");
            }
        }
    }
}

