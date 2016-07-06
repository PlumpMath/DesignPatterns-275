using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ConcreteElementA:Element
    {
        public override void accept(Visitor visitor)
        {
            visitor.visitConcreteElementA(this);
        }
    }
}
