using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string dateAsString = Console.ReadLine();
        DateTime dateTime = DateTime.ParseExact(dateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(dateTime.DayOfWeek);
    }
}