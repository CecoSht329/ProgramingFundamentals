using System;

namespace Elevator1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapaciy = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numberOfPeople / elevatorCapaciy);
            Console.WriteLine(courses);
        }
    }
}
