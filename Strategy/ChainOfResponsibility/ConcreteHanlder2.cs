using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConcreteHanlder2:Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 10 && request < 20)
                Console.WriteLine("the {0} handle the request {1}", this.GetType().Name, request);
            else
                Console.WriteLine("the request {0} can not be handled",request);
         }
    }
}
