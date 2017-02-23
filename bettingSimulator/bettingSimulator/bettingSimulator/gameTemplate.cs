using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator
{
    class gameTemplate<T> where T: class, IComparable<T>, new()
    {
        T myGame, otherGame;

        public gameTemplate()
        {
            myGame = new T();
        }
        
        
        public bool runGame()
        {
            //This little oddity of having the "otherGame" declared in this part is to insure that the poker
            //game has a hidden opponant hand.
            otherGame = new T();

            //Returns true if you win, false if you loose
            if (myGame.CompareTo(otherGame) == 1)
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
