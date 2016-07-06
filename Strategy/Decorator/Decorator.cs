using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Decorator:Component
    {
        protected Component component;

        public void setComponent(Component c) {
            component = c;
        }

        public override void Operation()
        {
            if (component != null)
                component.Operation();
         }
    }
}
