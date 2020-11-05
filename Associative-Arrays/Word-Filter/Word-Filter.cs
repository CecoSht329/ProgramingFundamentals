using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length % 2 == 0).ToArray();

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}
        Console.WriteLine(string.Join(Environment.NewLine, arr));
    }

}
