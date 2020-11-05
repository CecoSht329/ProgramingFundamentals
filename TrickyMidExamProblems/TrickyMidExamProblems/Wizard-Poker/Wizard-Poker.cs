using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
 
namespace WizardPoker
{
    class Program
    {
        public static void Main()
        {
            //tricky part swap command
            List<string> cards = Console.ReadLine().Split(':').ToList();
            List<string> newDeck = new List<string>();
            string command;
            while ((command = Console.ReadLine()) != "Ready")
            {
                string[] operation = command.Split();
                if (operation[0] == "Add")
                {
                    string cardName = operation[1];
                    if (cards.Contains(cardName))
                    {
                        newDeck.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (operation[0] == "Insert")
                {
                    string cardName = operation[1];
                    int index = int.Parse(operation[2]);
                    if (cards.Contains(cardName) && (index >= 0 && index <= cards.Count - 1) && index <= newDeck.Count - 1)
                    {
                        newDeck.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (operation[0] == "Remove")
                {
                    string cardName = operation[1];
                    if (newDeck.Contains(cardName))
                    {
                        newDeck.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (operation[0] == "Swap")//swap command
                {
                    string card1 = operation[1];
                    string card2 = operation[2];
                    int card1Index = newDeck.IndexOf(card1);
                    int card2Index = newDeck.IndexOf(card2);

                    string temp = newDeck[card1Index];
                    newDeck[card1Index] = newDeck[card2Index];
                    newDeck[card2Index] = temp;
                }
                else if (operation[0] == "Shuffle")
                {
                    newDeck.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", newDeck));
        }
    }

}