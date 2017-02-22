using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator
{
    class FiveCardStud
    {
        Deck theDeck;
        PlayingCard[] hand;

        public FiveCardStud()
        {
            hand = new PlayingCard[5];
            theDeck.shuffle();

            hand[0] = theDeck.drawCard();
            hand[1] = theDeck.drawCard();
            hand[2] = theDeck.drawCard();
            hand[3] = theDeck.drawCard();
            hand[4] = theDeck.drawCard();
        }
    }
}
