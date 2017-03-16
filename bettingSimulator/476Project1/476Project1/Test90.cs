using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _476Project1
{
    class Test90 : TestVersion
    {
        private static int numberInstanced = 0;
        private string version;
        private static Test90 instanceOne;

        private Test90()
        {;
            version = "Word90";
        }

        public static Test90 initialize()
        {
            if (numberInstanced < 2)
            {
                numberInstanced++;
                instanceOne = new Test90();
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
