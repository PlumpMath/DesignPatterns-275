using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Invoker
    {
        private IList<Command> commands=new List<Command>();

        public void addCommand(Command c) {
            commands.Add(c);
        }

        public void removerCommand(Command c) {
            commands.Remove(c);
        }

        public void Execute() {

            foreach (Command c in commands)
                c.Execute();
        }
    }
}
