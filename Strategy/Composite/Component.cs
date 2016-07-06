using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Component
    {
        protected String Name;
        public Component(String name) {
            Name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
        
    }
}
