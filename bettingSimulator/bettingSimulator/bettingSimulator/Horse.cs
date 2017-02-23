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
            run();
        }
         
        public int run()
        {
            time = random.Next(0, 100);
            return time;
        }

        public int CompareTo(Horse other)
        {
            Console.WriteLine($"Your horse's time: {time} Other horse's time: {other.Time}");
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
