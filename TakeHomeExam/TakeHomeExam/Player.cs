using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeExam
{
    //Player is a class to represent a player. It can have a hand and has an amount of cash it can bet
    //AiPlayer inherits Player and adds computer driver betting
    class Player : IComparable<Player>
    {
        protected double cash;
        protected double winnings;
        public PlayerHand myHand;
        protected bool folded;

        public Player()
        {
            myHand = new PlayerHand();
            cash = 100;
            winnings = 0;
            folded = false;
        }

        //Hand Management Methods
        public void newHand()
        {
            myHand = new PlayerHand();
            folded = false;
        }

        public void takeCard(PlayingCard card)
        {
            myHand.takeCard(card);
        }

        public virtual void addTableCards(PlayingCard[] table)
        {
            myHand.getTableCards(table);
            return;
        }

        //Betting management Methods
        public virtual string bet()
        {
            Console.WriteLine($"Your hand is: {myHand.ToString()}");
            
            if (!folded)
            {
                //Bet returns a string for what decision the player takes
                Console.Write("Human player, Do you raise, call, or fold: ");
                return Console.ReadLine();
            }
            else
            {
                return "fold";
            }
        }

        //Current Bet is the player's current bet. topBet is the bet being called
        public double call(double currentBet, double topBet)
        {
            cash -= (topBet - currentBet);
            return (topBet - currentBet);
        }

        //Gotta be able to raise
        public virtual double raise(double myBet, double currentBet)
        {
            Console.Write($"You have ${cash}, and the current bet is ${currentBet}. Enter your raise: $");
            double bet = Convert.ToDouble(Console.ReadLine());
            cash = cash - bet - call(myBet, currentBet);
            return bet;
        }

        public void fold()
        {
            folded = true;
        }

        //And gotta get dat cash
        public void receiveWinnings(double money)
        {
            winnings += money;
            cash += money;
        }

        public string getHand()
        {
            if(folded)
            {
                return "Folded";
            }
            return $"{myHand.printHand()}";
        }

        //Figure out if you loose
        public int CompareTo(Player other)
        {
            if(folded)
            {
                return -1;
            }
            else if(myHand.CompareTo(other.myHand) == -1)
            {
                return -1;
            }
            else if(myHand.CompareTo(other.myHand) == 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
