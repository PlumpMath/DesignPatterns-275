using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicState = 22;
            FlyweightFactory ff = new FlyweightFactory();

            Flyweight fw1 = ff.getFlyweight("X");
            fw1.operation(extrinsicState--);

            Flyweight fw2 = ff.getFlyweight("Y");
            fw1.operation(extrinsicState--);

            UnsharedConcreteFlyweight ucf = new UnsharedConcreteFlyweight();
            ucf.operation(extrinsicState--);


        }
    }
}
