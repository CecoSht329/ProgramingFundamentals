using System;

namespace Messages
{
    class Messages
    {
        static void Main(string[] args)
        {
            int clicks = int.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 0; i < clicks; i++)
            {
                string digits = Console.ReadLine();
                int digitLength = digits.Length;
                int digit = digits[0] - '0';//ASCII 
                //Когато вземеш елемента на нулевия индекс получаваш '6' но като char. 
                //Но според ASCII таблицата https://www.cs.cmu.edu/~pattis/15-1XX/common/handouts/ascii.html 
                //десетичната стойност на този char е 54, а на '0' -> 48 (54 - 48 = 6).
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    message += (char)(digit + 32);
                    continue;
                }

                if (digit == 8 || digit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + digitLength - 1;
                message += (char)(letterIndex + 97);
            }

            Console.WriteLine(message);
        }
    }
}

