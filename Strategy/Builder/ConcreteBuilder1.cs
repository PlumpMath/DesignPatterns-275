using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ConcreteBuilder1:Builder
    {
        private Product product = new Product();

        public override void buildPartA() {
            product.add("BigHead");
        }

        public override void buildPartB() {
            product.add("BigBody");
        }

        public override Product getResult()
        {
            return product;
        }
    }
}
