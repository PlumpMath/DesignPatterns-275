using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("leafA"));

            Composite compositeX=new Composite("compositeX");
            compositeX.Add(new Leaf("leafXA"));
            compositeX.Add(new Leaf("leafXB"));

            Composite compositeY = new Composite("compositeY");
            compositeY.Add(new Leaf("leafYA"));

            root.Add(compositeX);
            root.Add(compositeY);

            Console.WriteLine("the root tree is");
            root.Display(2);

            root.Remove(compositeX);
            Console.WriteLine("after remove compositeX");
            root.Display(2);

        }
    }
}
