using System;


class Program
{
    static void Main()
    {
        //input: Gosho Pesho
        //output: 53253
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.None);
        PrintResult(input);
    }

    private static void PrintResult(string[] input)
    {
        int sum = GetSumOfStrings(input[0], input[1]);
        Console.WriteLine(sum);
    }

    private static int GetSumOfStrings(string strOne, string strTwo)
    {
        int sum = 0;
        for (int i = 0; i < Math.Min(strOne.Length, strTwo.Length); i++)
        {
            sum += strOne[i] * strTwo[i];
        }
        if (strOne.Length != strTwo.Length)
        {
            int start = Math.Min(strOne.Length, strTwo.Length);
            int end = Math.Max(strOne.Length, strTwo.Length);
            for (int i = start; i < end; i++)
            {
                if (strOne.Length > strTwo.Length)
                {
                    sum += strOne[i];
                }
                if (strOne.Length < strTwo.Length)
                {
                    sum += strTwo[i];
                }
            }
        }

        return sum;
    }
}

