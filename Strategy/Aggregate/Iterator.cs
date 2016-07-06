using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
   abstract class Iterator
    {
       public abstract object First();
       public abstract object Next();
       public abstract Boolean IsDone();
       public abstract object CurrentItem();
    }
}
