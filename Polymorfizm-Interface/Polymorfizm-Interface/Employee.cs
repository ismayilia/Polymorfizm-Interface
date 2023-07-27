using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm_Interface
{
    internal class Employee: IEmployee, ICommon
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public string GetAddress()
        {
            return "Address";
        }

        public void getAge()
        {
            Console.WriteLine("Age");
        }

        public string GetFullName()
        {
            throw new NotImplementedException();
        }

        public void GetName()
        {
            Console.WriteLine("Name");
        }
    }
}
