using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteColleague1:Colleague
    {
        public ConcreteColleague1(Mediator m) : base(m) { }

        public void Send(String message) {
            mediator.send(this, message);
        }
        public void Notify(String message) {
            Console.WriteLine("{0} receive message: {1}",this.GetType().Name,message);
        }
    }
}
