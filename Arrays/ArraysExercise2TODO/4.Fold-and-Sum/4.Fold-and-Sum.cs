using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] mainArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int leftFoldIndex = mainArray.Length / 4 - 1;
        int rightFoldIndex = 3 * mainArray.Length / 4;

        int[] topArray = new int[mainArray.Length / 2];

        int howManyNumbersSoFar = 0;
        for (int i = leftFoldIndex; i >= 0; i--)
        {
            howManyNumbersSoFar++;
            topArray[leftFoldIndex - i] = mainArray[i];
        }
        for (int i = mainArray.Length - 1; i >= rightFoldIndex; i--)
        {
            topArray[mainArray.Length - 1 - i + howManyNumbersSoFar] = mainArray[i];
        }

        int[] bottomArray = new int[mainArray.Length / 2];

        for (int i = leftFoldIndex + 1; i < rightFoldIndex; i++)
        {
            bottomArray[i - howManyNumbersSoFar] = mainArray[i];
        }

        for (int i = 0; i < topArray.Length; i++)
        {
            Console.Write(topArray[i] + bottomArray[i] + " ");
        }
    }
}

