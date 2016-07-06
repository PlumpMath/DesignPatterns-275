using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        SubSystemOne ssone;
        SubSystemTwo sstwo;
        SubSystemThree ssthree;
        SubSystemFour ssFour;

        public Facade() {
            ssone = new SubSystemOne();
            sstwo = new SubSystemTwo();
            ssthree = new SubSystemThree();
            ssFour = new SubSystemFour();
        }

        public void MethodA() {
            Console.WriteLine("The method A");
            ssone.MethodOne();
            ssthree.MethodThree();
            ssFour.MethodFour();
        
        }
        public void MethodB() {
            Console.WriteLine("The method B");
            ssFour.MethodFour();
            sstwo.method();
            ssthree.MethodThree();
        }
    }
}
