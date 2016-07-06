using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Department
    {
        private int Id;
        private String Name;

        public int id {
            get { return Id; }
            set { Id = value; }
        }

        public String name {
            get { return name; }
            set { name = value; }
        }
    }
}
