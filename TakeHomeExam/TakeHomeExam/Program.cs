using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            PlayerHand player = new PlayerHand();
            PlayerHand player2 = new PlayerHand();
            PlayingCard[] table = new PlayingCard[5] {
                new PlayingCard(Suit.spades, Value.two),
                new PlayingCard(Suit.clubs, Value.six),
                new PlayingCard(Suit.diamonds, Value.five),
                new PlayingCard(Suit.hearts, Value.queen),
                new PlayingCard(Suit.spades, Value.ten) };

            player.takeCard(new PlayingCard(Suit.diamonds, Value.three));
            player.takeCard(new PlayingCard(Suit.spades, Value.four));
            player.getTableCards(table);

            player2.takeCard(new PlayingCard(Suit.diamonds, Value.five));
            player2.takeCard(new PlayingCard(Suit.hearts, Value.two));
            player2.getTableCards(table);

            Console.WriteLine($"Table Cards: {table[0].ToString()} {table[1].ToString()} {table[2].ToString()}");

            player.printAndScoreHand();
            player2.printAndScoreHand();

            if(player.CompareTo(player2) == -1)
            {
                Console.WriteLine("You Loose");
            }
            else if(player.CompareTo(player2) == 1)
            {
                Console.WriteLine("You Win");
            }
        }
    }
}
