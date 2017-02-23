using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bettingSimulator
{
    class PlayingCard
    {
        suite cardSuite;
        value cardValue;

        public PlayingCard(suite setSuite, value setValue)
        {
            cardSuite = setSuite;
            cardValue = setValue;
        }

        public void setValues(suite setSuite, value setValue)
        {
            cardSuite = setSuite;
            cardValue = setValue;
            return;
        }

        public value getValue()
        {
            return cardValue;
        }

        public suite getSuite()
        {
            return cardSuite;
        }

        public string card()
        {
            return cardValue.ToString() + " " + cardSuite.ToString();
        }
    }
}