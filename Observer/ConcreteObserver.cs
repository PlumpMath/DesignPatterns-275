using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObserver:Observer
    {
        private ConcreteSubject concretesubject;
        private string observerstate;
        private string name;

        public ConcreteObserver(ConcreteSubject subject, string Name) {
            concretesubject = subject;
            name = Name;
        }

        public override void Update()
        {
            observerstate = concretesubject.SubjectState;
            Console.WriteLine("observer {0} state is {1}",name,observerstate);
        }

        public ConcreteSubject Subject {
            get { return concretesubject; }
            set { concretesubject = value; }

        }
    }
}
