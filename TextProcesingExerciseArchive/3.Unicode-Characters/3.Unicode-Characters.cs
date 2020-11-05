using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string value = Console.ReadLine();

        var chars = value
            .Select(c => (int)c)
            .Select(c => $@"\u{c:x4}");

        var result = string.Concat(chars);

        Console.WriteLine(result);
    }
}

