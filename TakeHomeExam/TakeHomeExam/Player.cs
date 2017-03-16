using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeExam
{
    //Player is a class to represent a player. It can have a hand and has an amount of cash it can bet
    //AiPlayer inherits Player and adds computer driver betting
    class Player
    {
        private double cash;
        private double winnings;
        private PlayerHand myHand;

        public Player()
        {
            myHand = new PlayerHand();
            cash = 100;
            winnings = 0;
        }

        public void newHand()
        {
            myHand = new PlayerHand();
        }

        public void takeCard(PlayingCard card)
        {
            myHand.takeCard(card);
        }

        //Current Bet is the player's current bet. topBet is the bet being called
        public double call(double currentBet, double topBet)
        {
            cash -= (topBet - currentBet);
            return (topBet - currentBet);
        }

        //Gotta be able to raise
        public double raise()
        {
            Console.Write($"You have {cash}. Enter your bet: ");
            double bet = Convert.ToDouble(Console.ReadLine());
            cash -= bet;
            return bet;
        }

        //And gotta get dat cash
        public void receiveWinnings(double money)
        {
            winnings += money;
        }
    }
}
