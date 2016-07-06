using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    abstract class  Command
    {
        protected Receiver receiver;

        public Command(Receiver rc)
        {
           receiver=rc;
        }

        abstract public void Execute();
    }
}
