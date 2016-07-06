using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver("receiver");

            invoker.addCommand(new ConcreteCommandA(receiver));
            invoker.addCommand(new ConcreteCommandB(receiver));

            invoker.Execute();

        }
    }
}
