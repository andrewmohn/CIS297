using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bettingSimulator
{
    //Card enum for poker hands
    enum suite { clubs, diamonds, hearts, spades };
    enum value { two, three, four, five, six, seven, eight, nine, ten, jack, queen, king, ace };

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

            FiveCardStud test = new FiveCardStud();



            Console.ReadKey();
        }
    }
}
