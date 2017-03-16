using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _476Project1
{
    class TestFactory
    {
        public TestVersion createTest(string test)
        {
            TestVersion temp = null;
            try
            {
                if (test == "Word90")
                {
                    temp = Test90.initialize();
                }
                else if (test == "Word00")
                {
                    temp = Test00.initialize();
                }
                else if (test == "Word10")
                {
                    temp = Test10.initialize();
                }
                else if (test == "Word17")
                {
                    temp = Test17.initialize();
                }
                else
                {
                    temp = null;
                    throw new ArgumentException("Invalid version value.");
                }

                if (temp == null)
                {
                    throw new AccessViolationException($"Two members of the {test} item have already been tested.");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (AccessViolationException e)
            {
                Console.WriteLine(e.Message);
            }
            return temp;
        }
    }
}
