using System;
using System.Linq;
class AnythingWillDo
{
    static void Main()
    {
        int sequenceLength = int.Parse(Console.ReadLine());
        string input = string.Empty;

        while ((input = Console.ReadLine()) != "Clone them!")
        {
            int[] dnaData = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
    }
}

