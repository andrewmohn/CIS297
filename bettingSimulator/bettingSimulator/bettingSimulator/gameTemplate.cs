using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator
{
    class gameTemplate<T> where T: class, IComparable<T>, new()
    {
        double bet, winnings;
        T myGame, otherGame;

        public gameTemplate()
        {
            myGame = new T();
        }
        
        //Returns true if you win, false if you loose
        public bool runGame()
        {
            otherGame = new T();

            if(myGame.CompareTo(otherGame) == 1)
            {
                //I win
                return true;
            }
            else
            {
                //I loose
                return false;
            }
        }
    }
}
