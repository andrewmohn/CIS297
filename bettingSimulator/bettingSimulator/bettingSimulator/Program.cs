using System;

namespace bettingSimulator
{
    //Card enum for poker hands
    enum suite { clubs, diamonds, hearts, spades };
    enum value { two, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace };

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string decision;
            double winnings = 0, bet;

            while (true)
            {
                Console.WriteLine("Choose your game: ");
                decision = Console.ReadLine();
                if(decision == "poker")
                {
                    gameTemplate<FiveCardStud> pokerGame = new gameTemplate<FiveCardStud>();
                    Console.WriteLine("Place your bet: ");
                    bet = Convert.ToDouble(Console.ReadLine());
                    if (pokerGame.runGame())
                        winnings += 2 * bet;
                    else
                        winnings -= 2 * bet;
                }
                else if(decision == "powerball")
                {
                    gameTemplate<Powerball> powerballGame = new gameTemplate<Powerball>();
                    if (powerballGame.runGame())
                        winnings += 1000000;
                    else
                        winnings -= 2;
                }
                else if(decision == "horse racing")
                {
                    gameTemplate<Horse> horseGame = new gameTemplate<Horse>();
                    Console.WriteLine("Place your bet: ");
                    bet = Convert.ToDouble(Console.ReadLine());

                    if (horseGame.runGame())
                        winnings += 2 * bet;
                    else
                        winnings -= 2 * bet;
                }

                Console.WriteLine($"You have {winnings} in money won.");
            }
        }
    }
}
