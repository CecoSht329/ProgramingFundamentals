using System;
namespace ConsoleApp1
{

    class SpecialNumber
    {

        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= totalNumbers; currentNumber++)
            {
                int number = currentNumber;
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;//tuk dobavqm samo poslednata cifra na chisloto kym sumata 
                    number /= 10;
                }
                bool isSpecial = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{currentNumber} -> {isSpecial}");
            }
        }
    }
}
