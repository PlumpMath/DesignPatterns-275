﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Caretaker
    {
        private Memento memento;
        public Memento Memen {
            get { return memento; }
            set { memento = value; }
        }
    }
}
