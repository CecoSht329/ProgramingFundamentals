using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int employeeEficiency1 = int.Parse(Console.ReadLine());
        int employeeEficiency2 = int.Parse(Console.ReadLine());
        int employeeEficiency3 = int.Parse(Console.ReadLine());
        int peopleCount = int.Parse(Console.ReadLine());

        double totalEficiencyPerHour = employeeEficiency1 + employeeEficiency2 + employeeEficiency3;//all people employees can answer for 1 hour

        double hours = Math.Ceiling(peopleCount / totalEficiencyPerHour);
        if (hours <= 3)
        {
            Console.WriteLine($"Time needed: {hours}h.");
        }
        else
        {
            for (int i = 1; i <= hours; i++)
            {
                if (i % 4 == 0)
                {
                    hours++;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");

        }

    }
}

