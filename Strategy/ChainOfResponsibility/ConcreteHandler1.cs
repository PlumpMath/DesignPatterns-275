using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 0 && request < 10)
                Console.WriteLine("the {0} handle the request {1}", this.GetType().Name, request);

            else if (successor != null)
                successor.HandleRequest(request);

        }
    }
}
