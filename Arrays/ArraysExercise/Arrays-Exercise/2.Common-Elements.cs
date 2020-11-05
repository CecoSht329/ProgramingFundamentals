using System;
using System.Linq;


class Program
{
    static void Main()
    {
        string[] arr1 = Console.ReadLine().Split(" ");
        string[] arr2 = Console.ReadLine().Split(" ");

        for (int i = 0; i < arr2.Length; i++)
        {
            string element = arr2[i];
            for (int j = 0; j < arr1.Length; j++)
            {
                string elementFirst = arr1[j];
                if (element == elementFirst)
                {
                    Console.Write(element + " ");
                    break;//You put this because you don't have to check any more but you DO NOT HAVE TO PUT IT 
                }
            }
        }
    }
}

