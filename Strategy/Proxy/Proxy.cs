using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Proxy:Subject
    {
        private RealSubject realsubject;

        public override void Request()
        {
            if (realsubject == null)
                realsubject = new RealSubject();
            realsubject.Request();
        }
    }
}
