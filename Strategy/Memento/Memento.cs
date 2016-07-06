using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Memento
    {
        private String state;

        public Memento(String state) {
            this.state = state;
        }

        public String State {
            get { return state; }
            set { state = value; }
        }
    }
}
