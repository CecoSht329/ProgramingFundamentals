using System;
public class PalindromeExample
{
    public static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            CheckIsItPalindrome(input);
        }

    }
    static void CheckIsItPalindrome(string input)
    {
        int n = int.Parse(input);
        int r = 0;
        int sum = 0;
        int temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = (sum * 10) + r;
            n = n / 10;
        }
        if (temp == sum)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}


