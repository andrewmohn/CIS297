using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeExam
{
    class PlayerHand : IComparable<PlayerHand>
    {
        //myHand holds the two dealt cards
        private PlayingCard[] myHand;
        //theHand is the whole collection
        private PlayingCard[] theHand;
        //To store the type of hand that is scored
        private hands ScoredHandType;
        //Holds the top valued card i.e. the 7 in sevens over twos.
        private PlayingCard topScoringCard;


        public PlayingCard[] WholeHand { get { return theHand; } }
        public hands HandValue { get { return ScoredHandType; } }
        public PlayingCard HandHighValue { get { return topScoringCard; } }

        public PlayerHand()
        {
            //Two cards may be in a individual hand
            myHand = new PlayingCard[2];
            theHand = new PlayingCard[7];
        }

        //For testing
        public string printHand()
        {
            return $"{ScoredHandType} with {HandHighValue.ToString()} as the high card";
        }

        public void takeCard(PlayingCard card)
        {
            if(myHand[0] == null)
            {
                myHand[0] = card;
                topScoringCard = myHand[0];
            }
            else if(myHand[1] == null)
            {
                myHand[1] = card;
            }
        }

        //Pass the table cards to the player's hand for scoring.
        public void getTableCards(PlayingCard[] table)
        {
            theHand[0] = myHand[0];
            theHand[1] = myHand[1];
            theHand[2] = table[0];
            theHand[3] = table[1];
            theHand[4] = table[2];
            theHand[5] = table[3];
            theHand[6] = table[4];

            //Sort them since all scoring systems expect it
            sortTheHand();
        }

        private void sortTheHand()
        {
            PlayingCard temp;

            for (int i = 0; i < 6; i++)
            {
                for (int j = i; j < 7; j++)
                {
                    if (theHand[i].CardValue > theHand[j].CardValue)
                    {
                        temp = theHand[i];
                        theHand[i] = theHand[j];
                        theHand[j] = temp;
                    }
                }
            }
        }

        private void scoreTheHand()
        {
            findStraightFlush();
            findFourOfAKind();
            findFullHouse();
            findFlush();
            findStraight();
            findThreeOfAKind();
            findTwoPair();
            findPair();
            findHighCard();
        }

        private void findStraightFlush()
        {
            int straightCount;
            Value lastValue;
            Suit check;

            for (int i = 6; i > 0; i--)
            {
                straightCount = 0;
                check = theHand[i].CardSuit;
                lastValue = theHand[i].CardValue;

                for(int j = i - 1; j >= 0; j--)
                {
                    if (theHand[j].CardSuit == check && theHand[j].CardValue == lastValue - 1)
                    {
                        lastValue = theHand[j].CardValue;
                        straightCount++;
                    }

                    if(straightCount > 3)
                    {
                        ScoredHandType = hands.straightFlush;
                        topScoringCard = theHand[i];
                        return;
                    }
                }
            }
            return;         
        }

        private void findFourOfAKind()
        {
            //If the current Value is greater

            if (ScoredHandType > hands.fourOfAKind)
            {
                return;
            }

            PlayingCard fourCard;
            int cardCount;

            //We can save on a few iterations since one of the first two cards must be in the whole set
            for (int i = 6; i > 2; i--)
            {
                //Get the card we are checking for FOUR OF A KIND.
                fourCard = theHand[i];
                cardCount = 0;

                for (int j = i; j >= 0; j--)
                {
                    //Compare values
                    if (theHand[i].CardValue == theHand[j].CardValue)
                    {
                        //If a match is found
                        cardCount++;
                    }
                }

                //The algorithim will always increment once. More than three or >= 4
                if (cardCount > 3)
                {
                    ScoredHandType = hands.fourOfAKind;
                    topScoringCard = fourCard;
                }
            }
        }

        private void findFullHouse()
        {
            if (ScoredHandType > hands.fullHouse)
            {
                return;
            }

            PlayingCard threeOf, twoOf;
            bool foundOne = false;
            int cardCount;

            threeOf = null;
            twoOf = null;

            for (int i = 6; i > 0; i--)
            {
                //Get the first card we are checking for three of a kind.
                threeOf = theHand[i];
                cardCount = 0;

                for (int j = i; j >= 0; j--)
                {
                    //Compare values
                    if (theHand[i].CardValue == theHand[j].CardValue)
                    {
                        //If a match is found
                        cardCount++;
                    }
                }

                //The algorithim will always increment once. If we have any more than two, we have three.
                if (cardCount > 2)
                {
                    foundOne = true;
                }
            }

            //Find a pair only if three of a kind has already been found
            if (foundOne)
            {
                for (int i = 6; i > 0; i--)
                {
                    //Only check if the card is not the already seen card.
                    if (theHand[i] != threeOf)
                    {
                        twoOf = theHand[i];
                        cardCount = 0;

                        for (int j = i; j >= 0; j--)
                        {
                            //Compare values
                            if (theHand[i].CardValue == theHand[j].CardValue)
                            {
                                //If a match is found
                                cardCount++;
                            }
                        }

                        //If we get a second pair
                        if (cardCount > 1)
                        {
                            //We get the score and the higher of the two
                            ScoredHandType = hands.fullHouse;
                            topScoringCard = threeOf.CardValue > twoOf.CardValue ? threeOf : twoOf;
                        }
                    }
                }
            }
        }

        private void findFlush()
        {
            if (ScoredHandType > hands.flush)
            {
                return;
            }
            int hearts = 0, diamonds = 0, spades = 0, clubs = 0;

            //Count the number of each suit in the hand
            for (int i = 6; i > 0; i--)
            {
                if (theHand[i].CardSuit == Suit.hearts)
                {
                    hearts++;
                }
                else if( theHand[i].CardSuit == Suit.clubs)
                {
                    clubs++;
                }
                else if(theHand[i].CardSuit == Suit.diamonds)
                {
                    diamonds++;
                }
                else if(theHand[i].CardSuit == Suit.spades)
                {
                    spades++;
                }
            }

            //If you have enough to make a flush, count it.
            if(hearts > 3)
            {
                ScoredHandType = hands.flush;
                topScoringCard = highestCardOf(Suit.hearts);
            }
            else if (spades > 3)
            {
                ScoredHandType = hands.flush;
                topScoringCard = highestCardOf(Suit.spades);
            }
            else if (diamonds > 3)
            {
                ScoredHandType = hands.flush;
                topScoringCard = highestCardOf(Suit.diamonds);
            }
            else if (clubs > 3)
            {
                ScoredHandType = hands.flush;
                topScoringCard = highestCardOf(Suit.clubs);
            }

            return;
        }

        private void findStraight()
        {
            if(ScoredHandType > hands.straight)
            {
                return;
            }

            int straightCount;
            Value lastValue;

            //We need to count down to get the highest possible straight
            //Start the top end of the hand

            for (int i = 6; i > 0; i--)
            {
                //Check each card to see if it starts a straight
                straightCount = 0;
                lastValue = theHand[i].CardValue;
                for (int j = i - 1; j >= 0; j--)
                {
                    //If the current lastValue has a following value
                    if(theHand[j].CardValue == lastValue - 1)
                    {
                        //+1
                        straightCount++;
                        lastValue = theHand[j].CardValue;
                    }

                    //Count high enough and we have a straight
                    if (straightCount > 3)
                    {
                        ScoredHandType = hands.straight;
                        topScoringCard = theHand[i];
                        return;
                    }
                }
                //If straightCount reaches 4, it's a straight           
            }
        }

        private void findThreeOfAKind()
        {
            //If the current Value is greater

            if (ScoredHandType > hands.threeOfAKind)
            {
                return;
            }

            PlayingCard trioCard;
            int cardCount;

            for (int i = 6; i > 0; i--)
            {
                //Get the card we are checking.
                trioCard = theHand[i];
                cardCount = 0;

                for (int j = i; j >= 0; j--)
                {
                    //Compare values
                    if (theHand[i].CardValue == theHand[j].CardValue)
                    {
                        //If a match is found
                        cardCount++;
                    }
                }

                //The algorithim will always increment once. If any more than once, a pair exists.
                if (cardCount > 2 && trioCard.CardValue > topScoringCard.CardValue)
                {
                    ScoredHandType = hands.threeOfAKind;
                    topScoringCard = trioCard;
                }
            }
        }

        private void findTwoPair()
        {
            if(ScoredHandType > hands.twoPair)
            {
                return;
            }

            PlayingCard pairOne, pairTwo;
            bool foundOne = false;
            int cardCount;

            pairOne = null;
            pairTwo = null;

            for (int i = 6; i > 0; i--)
            {
                //Get the first card we are checking for a pair.
                pairOne = theHand[i];
                cardCount = 0;

                for (int j = i; j >= 0; j--)
                {
                    //Compare values
                    if (theHand[i].CardValue == theHand[j].CardValue)
                    {
                        //If a match is found
                        cardCount++;
                    }
                }

                //The algorithim will always increment once. If any more than once, a pair exists.
                if (cardCount > 1)
                {
                    foundOne = true;
                }
            }

            //Find second pair only if a pair has already been found
            if (foundOne)
            {
                for (int i = 6; i > 0; i--)
                {
                    //Only check if the card is not the already seen card.
                    if (theHand[i] != pairOne)
                    {
                        pairTwo = theHand[i];
                        cardCount = 0;

                        for (int j = i; j >= 0; j--)
                        {
                            //Compare values
                            if (theHand[i].CardValue == theHand[j].CardValue)
                            {
                                //If a match is found
                                cardCount++;
                            }
                        }

                        //If we get a second pair
                        if (cardCount > 1)
                        {
                            //We get the score and the higher of the two
                            ScoredHandType = hands.twoPair;
                            topScoringCard = pairOne.CardValue > pairTwo.CardValue ? pairOne : pairTwo;
                        }
                    }
                }
            }
        }

        private void findPair()
        {
            //If the current Value is greater

            if(ScoredHandType > hands.onePair)
            {
                return;
            }

            PlayingCard pairCard;
            int cardCount;

            for(int i = 6; i > 0; i--)
            {
                //Get the card we are checking for a pair.
                pairCard = theHand[i];
                cardCount = 0;

                for(int j = i; j >= 0; j--)
                {
                    //Compare values
                    if(theHand[i].CardValue == theHand[j].CardValue)
                    {
                        //If a match is found
                        cardCount++;
                    }
                }

                //The algorithim will always increment once. If any more than once, a pair exists.
                if(cardCount > 1 && pairCard.CardValue > topScoringCard.CardValue)
                {
                    ScoredHandType = hands.onePair;
                    topScoringCard = pairCard;
                }
            }
        }

        //Finds the high card in the whole hand
        private void findHighCard()
        {
            if(ScoredHandType > hands.highCard)
            {
                return;
            }

            ScoredHandType = hands.highCard;
            topScoringCard = theHand[6];
        }

        //Returns the higher Value card in your own hand
        private Value myHighCard()
        {
            return myHand[0].CardValue > myHand[1].CardValue ? myHand[0].CardValue : myHand[1].CardValue;
        }

        //If this function returns -1, 'this' looses
        public int CompareTo(PlayerHand opponent)
        {
            scoreTheHand();
            opponent.scoreTheHand();
            if (HandValue < opponent.HandValue)
            {
                return -1;
            }
            else if (HandValue > opponent.HandValue)
            {
                return 1;
            }
            else if (topScoringCard.CardValue < opponent.topScoringCard.CardValue)
            {
                return -1;
            }
            else if (topScoringCard.CardValue > opponent.topScoringCard.CardValue)
            {
                return 1;
            }
            else if(myHighCard() < opponent.myHighCard())
            {
                return -1;
            }
            else if (myHighCard() > opponent.myHighCard())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private PlayingCard highestCardOf(Suit suit)
        {
            for(int i = 6; i >= 0; i--)
            {
                if(theHand[i].CardSuit == suit)
                {
                    return theHand[i];
                }
            }

            return null;
        }

        public override string ToString()
        {
            return $"{myHand[0].ToString()} {myHand[1].ToString()}";
        }
    }
}
