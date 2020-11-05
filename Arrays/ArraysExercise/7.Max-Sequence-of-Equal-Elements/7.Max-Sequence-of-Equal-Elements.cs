using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int maxCount = 1;
        int currentCount = 1;
        int number = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            int previosNumber = nums[i - 1];
            int currentNumber = nums[i];

            if (previosNumber == currentNumber)
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    number = currentNumber;
                }
            }
            else
            {
                currentCount = 1;
            }
        }
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(number + " ");
        }
        
    }
}

