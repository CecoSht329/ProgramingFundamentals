using System;

namespace _01._Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();

            string input = "";

            while ((input = Console.ReadLine()) != "For Azeroth")
            {
                string[] command = input.Split();

                if (input.StartsWith("GladiatorStance"))
                {
                    skill = skill.ToUpper();
                    Console.WriteLine(skill);
                }
                else if (input.StartsWith("DefensiveStance"))
                {
                    skill = skill.ToLower();
                    Console.WriteLine(skill);
                }
                else if (input.StartsWith("Dispel"))//Tricky part-How to change a letter at certain index
                {
                    int index = int.Parse(command[1]);
                    char letter = char.Parse(command[2]);

                    if (index >= 0 && index < skill.Length)
                    {
                        char[] temp = skill.ToCharArray();
                        temp[index] = letter;
                        skill = new string(temp);

                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                }
                else if (input.StartsWith("Target Change"))//Tricky part how to replace every occurence 
                {
                    string oldSub = command[2];
                    string newSub = command[3];

                    while (skill.Contains(oldSub))
                    {
                        skill = skill.Replace(oldSub, newSub);
                    }

                    Console.WriteLine(skill);
                }
                else if (input.StartsWith("Target Remove"))//Tricky part how to remove every occurence 
                {
                    string substring = command[2];

                    int index = skill.IndexOf(substring);

                    while (skill.Contains(substring))
                    {
                        if (index > -1)
                        {
                            skill = skill.Remove(index, substring.Length);
                        }
                    }
                    Console.WriteLine(skill);
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }

        }
    }
}