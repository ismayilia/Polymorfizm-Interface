using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm_Interface
{
    internal class Person : IPerson
    {
        public string Name { get ; set; }

        public void getAge()
        {
            Console.WriteLine(22);
        }

        public void GetName()
        {
            Console.WriteLine("Fidan");
        }
    }
}
