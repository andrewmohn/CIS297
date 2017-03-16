using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeExam
{
    class AiPlayer : Player
    {
        private PlayingCard[] tableCards;

        public override void addTableCards(PlayingCard[] table)
        {
            tableCards = table;
            myHand.getTableCards(table);
            return;
        }

        public override string bet()
        {
            if(findWinChance() >= .5)
            {
                return "raise";
            }
            else
            {
                return "fold";
            }
        }

        public override double raise(double myBet, double currentBet)
        {
            double bet = 5;
            cash -= (bet - myBet);
            return bet;
        }

        private float findWinChance()
        {
            //WinChance is the % chance to win
            float winChance = 0;
            PlayingCard card1, card2;
            PlayerHand testHand;

            //To find the odds, we're going to build a massive chain of hands with every possible card except the cards in theHand
            //Then compare theHand to all other possible cards.

            //Basis of code taken from Deck
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    //Get the first possible card
                    card1 = new PlayingCard((Suit)i, (Value)j);
                    
                    //If don't have this card
                    if(!isCardOwned(card1))
                    {
                        //Then we get a second card
                        for (int k = i; k < 4; k++)
                        {
                            for (int l = j; l < 13; l++)
                            {
                                card2 = new PlayingCard((Suit)k, (Value)l);

                                //Check if this second card is out or if it is card1
                                if (!isCardOwned(card2) && card2.CompareTo(card1) != 0)
                                {
                                    //If not, then we check to see if this hand will beat ours
                                    //Create a hand and give it the cards
                                    testHand = new PlayerHand();
                                    testHand.takeCard(card1);
                                    testHand.takeCard(card2);
                                    testHand.getTableCards(tableCards);

                                    //If we win, increase winChance
                                    if(myHand.CompareTo(testHand) == 1)
                                    {
                                        winChance++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //45 taken in combenations of 2 is 990
            return winChance / 990;
        }

        private bool isCardOwned(PlayingCard card)
        {
            for(int i = 0; i < 7; i++)
            {
                if(card.CompareTo(myHand.WholeHand[i]) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
