using System;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            int subsequenseLength = 0;
            for (int j = i + 1; j < input.Length; j++)
            {
                char nextChar = input[j];
                if (currentChar == nextChar)
                {
                    subsequenseLength++;
                }
                else
                {
                    break;
                }
            }
            input = input.Remove(i + 1, subsequenseLength);
        }
        Console.WriteLine(input);
    }
}

