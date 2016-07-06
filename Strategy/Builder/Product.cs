using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Product
    {
        private IList<String> parts = new List<String>();

        public void add(String part) {
            parts.Add(part);
        }
        public void show() {
            Console.WriteLine("the product");
            foreach (String part in parts)
                Console.WriteLine(part);
        }
    }
}
