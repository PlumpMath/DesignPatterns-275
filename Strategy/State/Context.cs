using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Context
    {
        State state;

        public Context(State s)
        {
            state = s;
        }

        public State STATE
        {
            get { return state; }
            set { 
                    state = value;
                    Console.WriteLine("the current state is :"+state.GetType().Name);
            }
        }

        public void request() {
            state.Handle(this);
        }
    }
}
