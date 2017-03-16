using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeExam
{
    enum Suit { clubs, diamonds, hearts, spades };
    enum Value { two, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace };

    class PlayingCard : IComparable<PlayingCard>
    {
        private Suit cardSuit;
        private Value cardValue;

        public Suit CardSuit {  get { return cardSuit; } private set { cardSuit = value; } }
        public Value CardValue { get { return cardValue; } private set { cardValue = value; } }

        public PlayingCard(Suit setSuit, Value setValue)
        {
            cardSuit = setSuit;
            cardValue = setValue;
        }

        public override string ToString()
        {
            return cardValue.ToString() + " " + cardSuit.ToString();
        }

        public int CompareTo(PlayingCard other)
        {
            if(cardValue < other.CardValue)
            {
                return -1;
            }
            else if(cardValue > other.CardValue)
            {
                return 1;
            }
            if(CardSuit < other.CardSuit)
            {
                return -1;
            }
            else if(CardSuit > other.cardSuit)
            {
                return 1;
            }
            return 0;
        }
    }
}