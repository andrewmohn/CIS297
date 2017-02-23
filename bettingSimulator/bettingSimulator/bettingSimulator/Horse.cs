using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator 
{
    class Horse : IComparable<Horse>
    {
        private Random random;
        private int time;

        public int Time
        {
            get { return time; }
        }

        public Horse()
        {
            random = new Random();
            time = 0;
        }
         
        public int run()
        {
            time = random.Next(0, 100);
            return time;
        }

        public int CompareTo(Horse other)
        {
            if(other.Time > time)
            {
                return -1;
            }
            else if(other.Time < time)
            {
                return 1;
            }
            return 0;
        }
    }
}
