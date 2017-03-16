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
            TexasHoldEm game = new TexasHoldEm();
            
            while(true)
            {
                game.deal();
                game.betting();
                game.showdown();
            }
        }
    }
}
