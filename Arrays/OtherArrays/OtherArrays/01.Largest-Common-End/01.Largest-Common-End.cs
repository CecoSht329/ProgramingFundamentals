using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();
        string[] otherWords = Console.ReadLine().Split();

        int leftRightCounter = 0;
        int rightLeftCounter = 0;
        for (int i = 0; i < words.Length && i < otherWords.Length; i++)
        {
            if (words[i] == otherWords[i])
            {
                leftRightCounter++;
            }
        }

        for (int i = 0; i < words.Length && i < otherWords.Length; i++)
        {
            if (words[words.Length - 1 - i] == otherWords[otherWords.Length - 1 - i])
            {
                rightLeftCounter++;
            }
        }

        Console.WriteLine(rightLeftCounter > leftRightCounter ? rightLeftCounter : leftRightCounter);
    }
}

