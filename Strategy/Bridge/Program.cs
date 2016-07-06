using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RefinedAbstraction ra = new RefinedAbstraction();
            ra.Impl = new ConcreteImplementorA();
            ra.Opeartion();

            ra.Impl = new ConcreteImplementorB();
            ra.Opeartion();

        }
    }
}
