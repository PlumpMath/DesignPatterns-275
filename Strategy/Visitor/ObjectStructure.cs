using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ObjectStructure
    {
        private IList<Element> elements = new List<Element>();

        public void addElement(Element e) {
            elements.Add(e);
        }

        public void removeElment(Element e) {
            elements.Remove(e);
        }

        public void Accept(Visitor visitor) {
            foreach (Element e in elements)
                e.accept(visitor);
        }
    }
}
