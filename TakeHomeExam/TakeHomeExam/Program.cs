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
            PlayingCard[] table = new PlayingCard[5] { new PlayingCard(Suit.spades, Value.six), new PlayingCard(Suit.clubs, Value.three),
                new PlayingCard(Suit.diamonds, Value.four), new PlayingCard(Suit.clubs, Value.five), new PlayingCard(Suit.clubs, Value.two) };

            Console.WriteLine($"Table Cards: {table[0].ToString()}_{table[1].ToString()}_{table[2].ToString()}");

            player.takeCard(new PlayingCard(Suit.diamonds, Value.five));
            player.takeCard(new PlayingCard(Suit.hearts, Value.king));
            player.getTableCards(table);

            player.printAndScoreHand();
        }
    }
}
