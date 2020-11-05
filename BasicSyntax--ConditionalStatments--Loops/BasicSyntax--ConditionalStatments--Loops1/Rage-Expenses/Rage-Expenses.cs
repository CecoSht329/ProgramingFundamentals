    using System;

    namespace Rage_Expenses
    {
        class Program
        {
            static void Main(string[] args)
            {
                int lostGames = int.Parse(Console.ReadLine());
                decimal headsetPrice = decimal.Parse(Console.ReadLine());
                decimal mousePrice = decimal.Parse(Console.ReadLine());
                decimal keyboardPrice = decimal.Parse(Console.ReadLine());
                decimal displayPrice = decimal.Parse(Console.ReadLine());

                int thrashedHeadset = 0;
                int thrashedMouse = 0;
                int thrashedKeyboard = 0;
                int thrashedDisplay = 0;
                for (int lostGamesCounter = 1; lostGamesCounter <= lostGames; lostGamesCounter++)
                {
                    if (lostGamesCounter % 2 == 0)
                    {
                        thrashedHeadset++;
                    }
                    if (lostGamesCounter % 3 == 0)
                    {
                        thrashedMouse++;
                    }
                    if (lostGamesCounter % 2 == 0 && lostGamesCounter % 3 == 0)
                    {
                        thrashedKeyboard++;
                        if (thrashedKeyboard % 2 == 0)
                        {
                            thrashedDisplay++;
                        }
                    }
                }
                decimal rageExpenses = headsetPrice * thrashedHeadset + mousePrice * thrashedMouse +
                    keyboardPrice * thrashedKeyboard + displayPrice * thrashedDisplay;
                Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
            }
        }
    }
