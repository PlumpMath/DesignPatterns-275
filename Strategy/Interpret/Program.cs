using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpret
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            AbstractExpression ae1 = new NonterminalExpression();
            AbstractExpression ae2 = new TerminalExpression();
            ae1.interpret(context);
            ae2.interpret(context);
        }
    }
}
