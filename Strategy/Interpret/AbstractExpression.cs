using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpret
{
    abstract class AbstractExpression
    {
        public abstract void interpret(Context context);
    }
}
