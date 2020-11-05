using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //IN THIS ASIGNMENT YOU HAVE A VERY TRICKY PART ABOUT INDEXES OF AN ARRAY
        // Normaly if index does not match you ignore the command ,but here you can't ignore 
        // the command if the index does not match. It is shown here how to addapt to such circumstances.
        int[] targetsInArcheryField = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        string input;
        int points = 0;
        while ((input = Console.ReadLine()) != "Game over")
        {
            string[] commandInput = input.Split("@").ToArray();
            string command = commandInput[0];
            int startIndex; int length;
            switch (command)
            {
                case "Shoot Left"://tricky part 
                    startIndex = int.Parse(commandInput[1]);
                    length = int.Parse(commandInput[2]);
                    if (startIndex >= 0 && startIndex < targetsInArcheryField.Length)
                    {
                        int left = startIndex - length;
                        while (left < 0)
                        {
                            left = targetsInArcheryField.Length + left;
                        }
                        if (targetsInArcheryField[left] >= 5)
                        {
                            targetsInArcheryField[left] -= 5;
                            points += 5;
                        }
                        else
                        {
                            points += targetsInArcheryField[left];
                            targetsInArcheryField[left] = 0;
                        }
                    }
                    //Console.WriteLine(string.Join(" ", targetsInArcheryField));
                    break;
                case "Shoot Right"://also tricky part
                    startIndex = int.Parse(commandInput[1]);
                    length = int.Parse(commandInput[2]);
                    if (startIndex >= 0 && startIndex < targetsInArcheryField.Length)
                    {
                        int right = startIndex + length;
                        while (right >= targetsInArcheryField.Length)
                        {
                            right = right - targetsInArcheryField.Length;
                        }
                        if (targetsInArcheryField[right] >= 5)
                        {
                            targetsInArcheryField[right] -= 5;
                            points += 5;
                        }
                        else
                        {
                            points += targetsInArcheryField[right];
                            targetsInArcheryField[right] = 0;
                        }
                    }
                    break;
                case "Reverse":
                    targetsInArcheryField = targetsInArcheryField.Reverse().ToArray();
                    break;
            }
        }
        Console.WriteLine(string.Join(" - ", targetsInArcheryField));
        Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
    }
}