using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator
{
    class Powerball : IComparable<Powerball>
    {
        public int theNumber;
        static Random random = new Random();
        public Powerball()
        {
            theNumber = random.Next(100000, 1000000);
        }

        //To fit within the logic of other games, we return a win as if it is higher instead of the same
        public int CompareTo(Powerball other)
        {
            Console.WriteLine($"Your ticket number: {theNumber} The winning number: {other.theNumber}");
            if (other.theNumber == theNumber)
                return 1;
            else
                return 0;
        }
    }
}
