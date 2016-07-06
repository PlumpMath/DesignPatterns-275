using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            Department d = new Department();


            IUser iuser = DataAccess.CreateUser();
            IDepartment idepartment = DataAccess.CreateDepartment();

            iuser.Insert(u);
            iuser.GetUser();

            idepartment.InsertDepartment(d);
            idepartment.GetDepartment();
        }
    }
}
