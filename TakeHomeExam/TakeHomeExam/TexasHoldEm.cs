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
        //Players
        Player player1;
        AiPlayer player2;
        //Player bets
        double playerOneBet, playerTwoBet;
        //The deck
        Deck deck;
        //The three cards that are on the table
        PlayingCard[] table;

        //When creating the game, a deck is initilized and shuffled, and a table is created
        TexasHoldEm()
        {
            //Create the players
            player1 = new Player();
            player2 = new AiPlayer();
            deck = new Deck();
            deck.shuffle();
            table = new PlayingCard[5];
        }

        //On deal players discard their old hands
        public void deal()
        {
            player1.newHand();
            player2.newHand();

            //Deal two cards to each player
            for (int i = 0; i < 2; i++)
            {
                player1.takeCard(deck.drawCard());
                player2.takeCard(deck.drawCard());
            }

            //Deal five cards to the table
            for(int i = 0; i < 5; i++)
            {
                table[i] = deck.drawCard();
            }
        }

        //Betting
        public void bet()
        {

        }
    }
}
