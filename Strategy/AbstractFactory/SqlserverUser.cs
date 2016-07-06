using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SqlserverUser:IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("Insert one user in SQL Server");
        }

        public User GetUser() {
            Console.WriteLine("Get one user from SQL Server");
            return null;
        }
    }
}
