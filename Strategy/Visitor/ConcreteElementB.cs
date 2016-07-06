﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class ConcreteElementB:Element
    {
        public override void accept(Visitor visitor)
        {
            visitor.visitConcreteElementB(this);
        }
    }
}
