using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Client
    {
        static void Main(string[] args) {
            AbstractClass concreteclass1 = new ConcreteClass1();
            concreteclass1.TemplateMethod();

            AbstractClass concreteclass2 = new ConcreteClass2();
            concreteclass2.TemplateMethod();
        }

    }
}
