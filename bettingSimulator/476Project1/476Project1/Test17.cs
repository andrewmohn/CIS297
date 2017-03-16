using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _476Project1
{
    class Test17 : TestVersion
    {
        private static int numberInstanced = 0;
        private string version;
        private static Test17 instanceOne;

        private Test17()
        {
            version = "Word17";
        }

        public static Test17 initialize()
        {
            if (numberInstanced < 2)
            {
                numberInstanced++;
                instanceOne = new Test17();
                return instanceOne;
            }
            else
            {
                return null;
            }
        }

        override public string getButton()
        {
            return $"Button {version}";
        }

        public override string getTextbox()
        {
            return $"Textbox {version}";
        }

        public override string getWindow()
        {
            return $"Window {version}";
        }
    }
}
