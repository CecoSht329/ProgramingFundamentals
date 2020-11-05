using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < input.Length; i++)
        {
            int index = random.Next(0, input.Length - 1);
            string temp = input[index];
            input[index] = input[i];
            input[i] = temp;
        }
        Console.WriteLine(string.Join(Environment.NewLine, input));
    }
}

