using System;

namespace PadawanExperiment
{
    class PadawanExperiment
    {
        static void Main(string[] args)
        {
            decimal moneyAmount = decimal.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            decimal lightSabre = decimal.Parse(Console.ReadLine());//this is the price for a single LightSabre
            decimal robe = decimal.Parse(Console.ReadLine());//this is the price for a single robe
            decimal belt = decimal.Parse(Console.ReadLine());//this is the price for a single belt

            decimal extraSabres = Math.Ceiling(0.1m * countStudents);
            int freeBelts = 0;
            for (int counterBelts = 1; counterBelts <= countStudents; counterBelts++)
            {
                if (counterBelts % 6 == 0)
                {
                    freeBelts++;
                }
            }

            decimal neededEquipment = lightSabre * (countStudents + extraSabres) +
                belt * (countStudents - freeBelts) + robe * countStudents;
            if (moneyAmount >= neededEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {neededEquipment:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {neededEquipment - moneyAmount:f2}lv more.");
            }
        }
    }
}
