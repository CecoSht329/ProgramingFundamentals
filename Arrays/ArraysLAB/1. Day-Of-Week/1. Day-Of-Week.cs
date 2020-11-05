using System;

namespace _1._Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days =
                { 
                "Monday", 
                "Tuesday", 
                "Wednesday", 
                "Thursday", 
                "Friday", 
                "Saturday ", 
                "Sunday" };//this is the days their number is seven.

            int day = int.Parse(Console.ReadLine());//this is the input

            if (day < 1 || day > 7)//if the input is here the day is invalid 
            {
                Console.WriteLine("Invalid day!");
            }
            else//if else 
            {
                Console.WriteLine(days[day - 1]);//we have an array with seven days and whatever the input is it matches 
                                                 //the relevant day
            }
        }
    }
}
