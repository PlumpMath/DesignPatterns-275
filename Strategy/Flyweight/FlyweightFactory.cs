using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Flyweight
{
    class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public FlyweightFactory(){
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y",new ConcreteFlyweight());
            flyweights.Add("Z",new ConcreteFlyweight());
        }
        public Flyweight getFlyweight(String key) { 
         return (Flyweight)flyweights[key];
        }
    }
}
