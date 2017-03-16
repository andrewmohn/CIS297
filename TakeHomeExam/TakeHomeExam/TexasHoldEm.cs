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
        public TexasHoldEm()
        {
            //Create the players
            player1 = new Player();
            player2 = new AiPlayer();
            deck = new Deck();
            deck.shuffle();
            table = new PlayingCard[5];
        }

        //Deal a new hand
        public void deal()
        {
            Console.WriteLine("NEW GAME");
            //Neither player has bet
            playerOneBet = 0;
            playerTwoBet = 0;

            //Each player gets a new hand
            player1.newHand();
            player2.newHand();

            //Deck is reshuffled.
            deck = new Deck();
            deck.shuffle();

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

            player1.addTableCards(table);
            player2.addTableCards(table);

            Console.WriteLine($"Cards on the table are: {table[0].ToString()}, {table[1].ToString()}, {table[2].ToString()}, {table[3].ToString()}, {table[4].ToString()}, ");
        }

        //Betting
        public void betting()
        {
            bool called = false;
            int callCount = 0, foldCount = 0;
            double callBet = 0;

            //Until all each player has called or folded
            while(!called)
            {
                //We get the action for each player
                Console.WriteLine($"Current bet is: {playerTwoBet}. You have bet {playerOneBet}.");
                switch(player1.bet())
                {
                    case "raise":
                        callCount = 0;
                        playerOneBet += player1.raise(playerOneBet, playerTwoBet);
                        callBet = playerOneBet;
                        break;
                    case "call":
                        callCount++;
                        playerOneBet += player1.call(playerOneBet, callBet);
                        if(callCount == 1)
                        {
                            return;
                        }
                        break;
                    case "fold":
                        player1.fold();
                        foldCount++;
                        break;
                }
                switch (player2.bet())
                {
                    case "raise":
                        callCount = 0;
                        playerTwoBet += player2.raise(playerTwoBet, playerOneBet);
                        callBet = playerTwoBet;
                        break;
                    case "call":
                        callCount++;
                        playerTwoBet += player2.call(playerTwoBet, callBet);
                        if (callCount == 1)
                        {
                            return;
                        }
                        break;
                    case "fold":
                        player2.fold();
                        foldCount++;
                        break;
                }
                //If everyone but one person has folded
                if(foldCount == 1)
                {
                    //We end the loop
                    called = true;
                }
            }
            //Betting phase over
            return;
        }

        public void showdown()
        {
            double pot = playerOneBet + playerTwoBet;
            int decision = player1.CompareTo(player2);

            Console.WriteLine($"Player1 has {player1.getHand()}");
            Console.WriteLine($"Player2 has {player2.getHand()}");

            if(decision == 1)
            {
                Console.WriteLine($"Player1 has won ${pot}.");
                player1.receiveWinnings(pot);
                playerOneBet = 0;
                playerTwoBet = 0;
            }
            if(decision == -1)
            {
                Console.WriteLine($"Player2 has won ${pot}.");
                player2.receiveWinnings(pot);
                playerOneBet = 0;
                playerTwoBet = 0;
            }
            else if(decision == 0)
            {
                Console.WriteLine($"Each player has won ${pot/2}.");
                player1.receiveWinnings(pot/2);
                player2.receiveWinnings(pot / 2);
            }
        }
    }
}
