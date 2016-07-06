using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AccessUser:IUser
    {
        public void Insert(User user){
            Console.WriteLine("Insert one user in Access");
        }

        public User GetUser() {
            Console.WriteLine("Get one user in Access");
            return null;
        }
    }
}
