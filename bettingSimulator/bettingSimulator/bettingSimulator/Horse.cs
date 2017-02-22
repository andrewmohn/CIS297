using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator
{
    class Horse
    {
        Random random;
        int time;

        Horse()
        {
            random = new Random();
            time = 0;
        }
         
        public int run()
        {
            time = random.Next(0, 100);
            return time;
        }
    }
}
