using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    class ConcreteIterator:Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate concreteaggregate) {
            aggregate = concreteaggregate;
        }

        public override object First()
        {
            if (aggregate.Count > 0)
                return aggregate[0];
            else
                return null;
        }

        public override object Next()
        {
            if (++current < aggregate.Count)
                return aggregate[current];
            else
                return null;
        }

        public override object CurrentItem()
        {
            if (current < aggregate.Count)
                return aggregate[current];
            else
                return null;
        }

        public override bool IsDone()
        {
            return current < aggregate.Count ? false : true;
        }
    }
}
