using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Context
    {
        Strategy strategy;
        public Context(Strategy s) {
            strategy = s;
        }
        public void ContectInterface() {
            strategy.AlgorithmInterface();
        }
    }
}
