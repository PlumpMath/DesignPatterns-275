using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Client
    {
        static void Main(string[] args)
        {
            Context contextA = new Context(new ConcreteStrategyA());
            contextA.ContectInterface();

            Context contextB = new Context(new ConcreteStrategyB());
            contextB.ContectInterface();

            Context contextC = new Context(new ConcreteStrategyC());
            contextC.ContectInterface();
        }
    }
}
