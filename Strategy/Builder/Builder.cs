using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   abstract class Builder
    {
        public abstract void buildPartA();
        public abstract void buildPartB();
        public abstract Product getResult();

    }
}
