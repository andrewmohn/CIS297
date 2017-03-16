using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeExam
{
    class Deck
    {
        private PlayingCard[] thisDeck;
        private int topCard;

        //Constructor creates a deck
        //Suit and Value are enum declared in the Program.cs file
        public Deck()
        {
            topCard = 0;
            thisDeck = new PlayingCard[52];

            //i increments Suit, j increments Value
            for (int i = 0, k = 0; i < 4; i++)
            {
                //k is incremnted every time to count off 52 cards
                for (int j = 0; j < 13; j++, k++)
                {
                    thisDeck[k] = new PlayingCard((Suit)i, (Value)j);
                }
            }
        }

        //Shuffle the Deck
        public void shuffle()
        {
            Random random = new Random();
            int randomNumber1, randomNumber2;

            topCard = 0;

            for(int i = 0; i < 200; i++)
            {
                randomNumber1 = random.Next(0, 52);
                randomNumber2 = random.Next(0, 52);

                swapCards(randomNumber1, randomNumber2);
            }
            return;
        }

        //Draw a card
        public PlayingCard drawCard()
        {
            //Return a card and advance the top card pointer
            return thisDeck[topCard++];
        }

        //Swap card function for shuffling the deck
        private void swapCards(int one, int two)
        {
            PlayingCard tempCard;

            tempCard = thisDeck[one];
            thisDeck[one] = thisDeck[two];
            thisDeck[two] = tempCard;

            return;
        }
    }
}