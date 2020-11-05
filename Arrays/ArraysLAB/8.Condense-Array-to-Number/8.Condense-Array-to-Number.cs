using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int[] mainArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

        while (mainArray.Length != 1)
        {
            int[] newArr = new int[mainArray.Length - 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = mainArray[i] + mainArray[i + 1];
            }
            mainArray = newArr;
        }
        Console.WriteLine(string.Join(" ", mainArray));
    }
}

