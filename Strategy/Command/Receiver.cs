using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Receiver
    {
        private String Name;

        public Receiver(String name) {
            Name = name;
        }

        public void ActionA() {
            Console.WriteLine("the action A executed");
        }
        public void ActionB() {
            Console.WriteLine("the action B executed");
        }
    }
}
