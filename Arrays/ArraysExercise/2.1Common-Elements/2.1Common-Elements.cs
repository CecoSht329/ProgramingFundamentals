using System;
using System.Linq;

namespace _2._1Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ");
            string[] arr2 = Console.ReadLine().Split(" ");

            for (int i = 0; i < arr2.Length; i++)
            {
                string element = arr2[i];
                if (arr1.Contains(element))
                {
                    Console.Write(element + " ");
                }
            }
        }
    }
}
