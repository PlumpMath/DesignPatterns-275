using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
namespace AbstractFactory
{
    class DataAccess
    {
        private static readonly String db=ConfigurationManager.AppSettings["DB"];
        private static readonly String AssemblyName = "AbstractFactory";

        public static IUser CreateUser() { 
            String classname=AssemblyName+"."+db+"User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(classname);
        }

        public static IDepartment CreateDepartment()
        {
            String classname = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(classname);
        }

    }
}
