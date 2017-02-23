using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator 
{
    class Horse : IComparable<Horse>
    {
        //Static random to insure no duplicate numbers
        static private Random random = new Random();
        private int time;

        public int Time
        {
            get { return time; }
        }

        public Horse()
        {
            time = random.Next(0, 100);
        }
  
        //Simply check to see which horse's number is lower
        public int CompareTo(Horse other)
        {
            Console.WriteLine($"Your horse's time: {time} Other horse's time: {other.Time}");
            if(other.Time > time)
            {
                return 1;
            }
            else if(other.Time < time)
            {
                return -1;
            }
            return 0;
        }
    }
}
