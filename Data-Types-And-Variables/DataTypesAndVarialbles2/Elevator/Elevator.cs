using System;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapaciy = int.Parse(Console.ReadLine());
            int courses = numberOfPeople / elevatorCapaciy;
            if (numberOfPeople % elevatorCapaciy != 0)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
