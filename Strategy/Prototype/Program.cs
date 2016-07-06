using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototypeA cpa1 = new ConcretePrototypeA("prototype");

            ConcretePrototypeA cpa2 = (ConcretePrototypeA)cpa1.Clone();

            Console.WriteLine("The Id of cpa2 is "+cpa1.id);
        }
    }
}
