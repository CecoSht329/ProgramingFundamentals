using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        for (int i = 0; i < arr.Length; i++)
        {
            bool isTop = true;
            int currentInteger = arr[i];
            for (int j = i + 1; j < arr.Length; j++)
            {
                int nextInteger = arr[j];
                if (currentInteger <= nextInteger)
                {
                    isTop = false;
                    break;
                }
            }
            if (isTop)
            {
                Console.Write(currentInteger + " ");
            }
        }
    }
}

