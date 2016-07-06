using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class ConcreteFlyweight:Flyweight
    {
        public override void operation(int extrinsicState) {
            Console.WriteLine("the concrete flyweight state: {0}",extrinsicState);
        }
    }
}
