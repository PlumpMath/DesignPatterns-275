using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "on";
            originator.show();

            Caretaker caretaker = new Caretaker();
            caretaker.Memen = originator.createMemento();

            originator.State = "off";
            originator.show();

            originator.setMemento(caretaker.Memen);
            originator.show();

        }
    }
}
