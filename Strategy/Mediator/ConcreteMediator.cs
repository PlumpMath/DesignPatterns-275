using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteMediator:Mediator
    {
        private ConcreteColleague1 cc1;
        private ConcreteColleague2 cc2;

        public ConcreteColleague1 CC1{
          set{cc1=value;}
        }

        public ConcreteColleague2 CC2 {
            set { cc2 = value; }
        }

        public override void send(Colleague c, String message) {
            if (c == cc1)
                cc2.Notify(message);
            else if (c == cc2)
                cc1.Notify(message);
            else
                Console.WriteLine("invalid message!!!");
            }
    }
}
