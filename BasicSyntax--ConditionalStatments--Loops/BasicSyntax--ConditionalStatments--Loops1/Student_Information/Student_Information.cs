using System;

namespace Student_Information
{
    class Student_Information
    {
        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            var studentAge = int.Parse(Console.ReadLine());
            var grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {grade:f2}");
        }
    }
}
