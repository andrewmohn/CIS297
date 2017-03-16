using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _476Project1
{
    class Test
    {
        public static TestFactory factory = new TestFactory();
        public static TestVersion test;

        static void Main(string[] args)
        {
            try
            {   // Open the text file using a stream reader.
                StreamReader sr = new StreamReader("C:\\Users\\Andrew\\Documents\\GitHub\\CIS297\\bettingSimulator\\476Project1\\476Project1\\testSchedule.txt");
                // Read the stream to a string, and write the string to the console.
                String line = sr.ReadLine();

                while(line != null)
                {
                    test = factory.createTest(line);
                    if (test != null)
                    {
                        testButton(test);
                        testWindow(test);
                        testTextbox(test);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static void testButton(TestVersion test)
        {
            Console.WriteLine(test.getButton());
        }

        public static void testWindow(TestVersion test)
        {
            Console.WriteLine(test.getWindow());
        }

        public static void testTextbox(TestVersion test)
        {
            Console.WriteLine(test.getTextbox());
        }
    }
}
