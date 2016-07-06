using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonStatic sstance1 = SingletonStatic.getInstance();
            SingletonStatic sstance2 = SingletonStatic.getInstance();

            if (sstance1 == sstance2)
                Console.WriteLine("the two SingletonStatic is the same ");


        }
    }
}
