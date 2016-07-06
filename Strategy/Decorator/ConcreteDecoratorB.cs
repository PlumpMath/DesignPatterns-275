using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteDecoratorB:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("The concrete decorator B operation");
        }
    }
}
