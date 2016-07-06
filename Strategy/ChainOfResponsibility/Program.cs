using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteHandler1 ch1 = new ConcreteHandler1();
            ConcreteHanlder2 ch2 = new ConcreteHanlder2();
            ch1.Successor = ch2;

            ch1.HandleRequest(3);
            ch1.HandleRequest(18);
            ch1.HandleRequest(25);
        }
    }
}
