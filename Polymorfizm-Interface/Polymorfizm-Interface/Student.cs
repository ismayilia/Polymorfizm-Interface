using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm_Interface
{
    internal class Student : IStudent, ICommon
    {
        public string FullName { get; set; }

        public string GetFullName()
        {
            throw new NotImplementedException();
        }

        public void ShowAge()
        {
            Console.WriteLine(30);
        }
    }
}
