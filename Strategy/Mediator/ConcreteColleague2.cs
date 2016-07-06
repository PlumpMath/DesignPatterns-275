using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ConcreteColleague2:Colleague
    {
        public ConcreteColleague2(Mediator m) : base(m) { }

        public void send(String messge) {
            mediator.send(this,messge);
        }
        public void Notify(String message) {
            Console.WriteLine("{0} receive message: {1}",this.GetType().Name,message);
        }
    }
}
