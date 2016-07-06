using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ConcreteVisitor2 : Visitor
    {
        public override void visitConcreteElementA(ConcreteElementA cea)
        {
            Console.WriteLine("the {0} is visiting {1}", this.GetType().Name, cea.GetType().Name);
        }
        public override void visitConcreteElementB(ConcreteElementB ceb)
        {
            Console.WriteLine("the {0} is visiting {1}", this.GetType().Name, ceb.GetType().Name);
        }
    }
}
