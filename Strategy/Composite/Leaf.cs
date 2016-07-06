using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Leaf:Component
    {
        public Leaf(String name)
            : base(name)
        { }

        public override void Add(Component component)
        {
            Console.WriteLine("This is a leaf and cann't add to a leaf");
        }
        public override void Remove(Component component)
        {
            Console.WriteLine("This is a leaf and cann't remove from a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth)+" "+Name);
        }
    }
}
