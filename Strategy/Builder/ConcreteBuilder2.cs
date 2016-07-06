using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ConcreteBuilder2:Builder
    {
        private Product product = new Product();

        public override void buildPartA()
        {
            product.add("SmallHead");
        }
        public override void buildPartB()
        {
            product.add("SmallBody");
        }

        public override Product getResult()
        {
            return product;
        }
    }
}
