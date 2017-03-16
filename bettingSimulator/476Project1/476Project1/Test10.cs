using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _476Project1
{
    class Test10 : TestVersion
    {
        private static int numberInstanced = 0;
        private string version;
        private static Test10 instanceOne;

        private Test10()
        {
            version = "Word10";
        }

        public static Test10 initialize()
        {
            if (numberInstanced < 2)
            {
                numberInstanced++;
                instanceOne = new Test10();
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
