using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split()
            .Select(x => int.Parse(x)).OrderByDescending(x => x)
            .Take(3)
            .ToList();

        //Console.WriteLine(string.Join(" ", numbers));


        //ternary conditional operator
        //condition ? consequent : alternative
        //is this condition true ? yes : no
        for (int i = 0; i < (numbers.Count < 3 ? numbers.Count : 3); i++) /*-- if you use this way take of.Take(3)from the list*/
        {
            Console.Write(numbers[i] + " ");
        }
    }
}
