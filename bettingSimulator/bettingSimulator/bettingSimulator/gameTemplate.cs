using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator
{
    class gameTemplate<T> where T: class, IComparable<T>, new()
    {
        double bet;
        T myGame, game1, game2, game3, game4;

        public gameTemplate<T>()
        public gameTemplate(T game)
        {
            myGame = new T();
        }
    }
}
