using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Originator
    {

        private String state;
        public String State {
            get { return state; }
            set { state = value; }
        }
        public Memento createMemento() {
            return( new Memento(state));
        }
        public void setMemento(Memento memento) {
            state = memento.State;
        }

        public void show() {
            Console.WriteLine("state="+state);
        }
    }
}
