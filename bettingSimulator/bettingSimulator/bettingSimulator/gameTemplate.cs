using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator
{
    class gameTemplate<T> where T: class, IComparable<T>
    {
        double bet;
        

        public gameTemplate(T game)
        {
            
        }
    }
}
