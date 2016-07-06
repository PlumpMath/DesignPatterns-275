using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {

            ObjectStructure os = new ObjectStructure();

            os.addElement(new ConcreteElementA());
            os.addElement(new ConcreteElementB());

            os.Accept(new ConcreteVisitor1());

            os.Accept(new ConcreteVisitor2());
        }
    }
}
