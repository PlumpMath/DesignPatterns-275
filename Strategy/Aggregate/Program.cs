using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {

            ConcreteAggregate ca = new ConcreteAggregate();
            ca[0] = "first";
            ca[1] = "second";
            ca[2] = "third";
            ca[3] = "forth";

            Iterator it = ca.CreateIterator();

            for (; !it.IsDone();it.Next() )
            {
                Console.WriteLine("the current item is " + it.CurrentItem());
            } 

        }
    }
}
