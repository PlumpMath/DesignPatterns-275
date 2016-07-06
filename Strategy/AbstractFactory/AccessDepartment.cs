using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AccessDepartment : IDepartment
    {
        public void InsertDepartment(Department department)
        {
            Console.WriteLine("Insert one department in Access");
        }

        public Department GetDepartment()
        {
            Console.WriteLine("Get one department in Access");
            return null;
        }
    }
}
