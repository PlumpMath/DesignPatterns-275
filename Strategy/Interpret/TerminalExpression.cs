using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpret
{
    class TerminalExpression:AbstractExpression
    {
        public override void interpret(Context context)
        {
            Console.WriteLine("this is the termial interpret ");
        }
    }
}
