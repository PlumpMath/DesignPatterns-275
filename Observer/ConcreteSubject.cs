using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteSubject:Subject
    {
        private string subjectstate;
        public string SubjectState {
            get { return subjectstate; }
            set { subjectstate = value; }
        }
    }
}
