using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "x"));
            s.Attach(new ConcreteObserver(s,"Y"));

            s.SubjectState = "hello ,how r u";
            s.Notify();

        }
    }
}
