using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prototype
{
    class ConcretePrototypeA:ICloneable
    {
        private String Id;

        public ConcretePrototypeA(String id) {
            Id = id;
        }
        public String id {
            get { return Id; }
            set { Id = value; }
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
