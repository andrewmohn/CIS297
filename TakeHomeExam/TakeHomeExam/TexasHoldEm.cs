using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeExam
{
    enum hands { highCard, onePair, twoPair, threeOfAKind, straight, flush, fullHouse, fourOfAKind, straightFlush, fiveOfAKind };

    class TexasHoldEm
    {
        PlayingCard[] myHand;

        private void sortMyHand()
        {
            PlayingCard temp;

            for(int i = 0; i < 4; i++)
            {
                for(int j = i; j < 5; j++)
                {
                    if(myHand[i].getValue() > myHand[j].getValue())
                    {
                        temp = myHand[i];
                        myHand[i] = myHand[j];
                        myHand[j] = temp;
                    }
                }
            }
        }

        public hands valueHand()
        {
            bool flush = true;
            int countCard = 0;
            suite checkFlush;
            hands thisHand = hands.highCard;

            //This loop finds multiple card hand values
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (hand[i].getValue() == hand[j].getValue())
                    {
                        countCard++;
                    }
                }
                //As we have not checked for straight flush yet, four of a kind is the highest
                //value possible.
                if (countCard == 3)
                {
                    thisHand = hands.fourOfAKind;
                }
                else if (countCard == 2 && thisHand == hands.onePair)
                {
                    //if we have found one pair and then find three of a kind,
                    //we have found a full house.
                    thisHand = hands.fullHouse;
                }
                //If the hand is valued at four of a kind we keep the higher value
                else if (countCard == 2 && thisHand < hands.threeOfAKind)
                {
                    thisHand = hands.threeOfAKind;
                }
                else if (countCard == 1 && thisHand == hands.onePair)
                {
                    //If thisHand is one pair, then a second pair being counted requires that
                    //that pair be of a different value
                    thisHand = hands.twoPair;
                }
                else if (countCard == 1 && thisHand < hands.onePair)
                {
                    thisHand = hands.onePair;
                }

                countCard = 0;
            }
            //If we have a three of a kind, we need to check for a missed full house
            if (thisHand == hands.threeOfAKind && thisHand < hands.fullHouse)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (hand[i] == hand[j])
                        {
                            countCard++;
                        }
                    }
                    if (countCard == 1)
                    {
                        //If we count a pair, then we have a full house
                        return hands.fullHouse;
                    }
                    else if (countCard == 2 && hand[i].getValue() == hand[i + 1].getValue())
                    {
                        //If we have counted three of a kind from hand[i], and
                        //hand[i+1] is of the same type then we must avoid "double counting" the
                        //card.
                        i++;
                        //i++ will "skip" one card and move to counting the third card in the hand
                        //Even if three cards of the same type are in a row, this will skip them.
                    }
                    countCard = 0;
                }
            }

            //Finally, we check for straights and flushes.

            //Reset the card count
            countCard = 0;
            //All five cards must be the same suite to be a flush
            checkFlush = hand[0].getSuite();


            for (int i = 0; i < 5; i++)
            {
                //Check to see if four PlayingCards have a following value card
                for (int j = 0; j < 5; j++)
                {
                    if (hand[i].getValue() + 1 == hand[j].getValue())
                    {
                        //If we find the value + 1
                        countCard++;
                    }
                }
                if (hand[i].getSuite() != checkFlush)
                {
                    flush = false;
                }
            }

            //If there are five sequential cards
            if (countCard == 4 && flush)
            {
                return hands.straightFlush;
            }
            //If the hand is a flush and the value is less than that
            else if (flush && thisHand < hands.flush)
            {
                return hands.flush;
            }
            else if (countCard == 4)
            {
                return hands.straight;
            }

            return thisHand;
        }



        private string findTwoPair()
        {

        }

        private string findPair()
        {

        }

        private string findHighCard()
        {
            string high;

            for (int i = 0; i < 5; i++)
            {
                if (myHand[i].getValue() > high.getValue())
                {
                    high = hand[i];
                }
            }
            return high;
        }
    }
}
