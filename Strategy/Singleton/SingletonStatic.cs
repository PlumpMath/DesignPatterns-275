using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonStatic
    {
        private static readonly SingletonStatic instance = new SingletonStatic();
        private SingletonStatic() { }

        public static SingletonStatic getInstance() {
            return instance;
        }

    }
}
