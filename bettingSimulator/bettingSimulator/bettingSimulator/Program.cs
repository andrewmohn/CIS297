using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bettingSimulator
{
    enum suite { hearts, diamonds, clubs, spades };
    enum value { ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king };
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Deck testDeck = new Deck();
            testDeck.shuffle();

            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(testDeck.drawCard().card());
            }

            Console.ReadKey();
        }
    }
}
