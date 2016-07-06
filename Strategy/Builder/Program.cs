using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director d = new Director();
            ConcreteBuilder1 cb1 = new ConcreteBuilder1();
            ConcreteBuilder2 cb2 = new ConcreteBuilder2();

            d.Construct(cb1);
            Product p1 = cb1.getResult();
            p1.show();

            d.Construct(cb2);
            Product p2 = cb2.getResult();
            p1.show();


        }
    }
}
