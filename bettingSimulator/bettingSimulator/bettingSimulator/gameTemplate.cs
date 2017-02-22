using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator
{
    class gameTemplate<T> : IComparable<T>
    {
        double bet;
        

        public gameTemplate(T game)
        {
            
        }

        //CompareTo returns -1 if "this" is lower, 0 if equal, 1 if greater
        public int CompareTo(T value)
        {
            int result = 0;

            if(true)
            {
                result = 0;
            }

            return result;
        }
    }
}
