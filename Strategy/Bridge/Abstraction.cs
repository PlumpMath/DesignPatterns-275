using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Abstraction
    {
        private Implementor implementor;
        public virtual void Opeartion() {
            implementor.OperationImp();
        } 

        public Implementor Impl{
         get {return implementor;}
            set { implementor = value; }
        }
    }
}
