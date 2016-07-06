using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
   abstract class Handler
    {
       protected Handler successor;

       public Handler Successor {
           get { return successor; }
           set { successor = value; }
       }

       public abstract void HandleRequest(int request);
    }
}
