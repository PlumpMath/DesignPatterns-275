using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ConcreteCommandB:Command
    {
        public ConcreteCommandB(Receiver rc) : base(rc) { }

        public override void Execute()
        {
            receiver.ActionB();
        }
    }
}
