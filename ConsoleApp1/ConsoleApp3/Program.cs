using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex validateTicketLength = new Regex(@"^.{20}$");
            Regex validateWinningTickets = new Regex(@"[@|#|$|^]{6,10}");

            string[] tickets = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string ticket in tickets)
            {
                Match validLength = validateTicketLength.Match(ticket);
                if (validLength.Success)
                {
                    string firstHalf = ticket.Substring(0, 10);
                    string secondHalf = ticket.Substring(10, 10);

                    Match winningTicketFirstHalf = validateWinningTickets.Match(firstHalf);
                    Match winningTicketSecondHalf = validateWinningTickets.Match(secondHalf);

                    if (winningTicketFirstHalf.Length == 10 && winningTicketSecondHalf.Length == 10)
                    {
                        string temp = winningTicketFirstHalf.ToString();
                        Console.WriteLine($"ticket \"{ticket}\" - {winningTicketSecondHalf.Length}{temp[0]} Jackpot!");
                    }
                    else if (winningTicketFirstHalf.Length >= 6 && winningTicketSecondHalf.Length >= 6)
                    {
                        string temp = winningTicketFirstHalf.ToString();
                        Console.WriteLine($"ticket \"{ticket}\" - {winningTicketFirstHalf.Length}{temp[0]}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }

            }
        }
    }
}
