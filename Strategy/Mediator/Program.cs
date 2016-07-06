using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();
            ConcreteColleague1 cc1 = new ConcreteColleague1(m);
            ConcreteColleague2 cc2 = new ConcreteColleague2(m);

            m.CC1 = cc1;
            m.CC2 = cc2;

            cc1.Send("hello, how r u?");
            cc2.send("Fine, Thanks. Would u like some coffee sometimes");
        }
    }
}
