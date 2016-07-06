using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ConcreteClass1:AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Primitive Operation1 implementation 1");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Primitive Operation2 implementation 1");
        }
    }
}
