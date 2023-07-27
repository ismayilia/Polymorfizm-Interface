using Polymorfizm_Interface.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm_Interface.Services
{
    internal class EmployeeService : IEmployeeService
    {
        public void Search(string searchText)
        {
            string result;
            string[] employees = { "Pervin", "Sheref", "Cahangir", "Fidan", "Kubra" };



            foreach (var item in employees)
            {
                if (item.Contains(searchText))
                {
                    Console.WriteLine(item);
                }
            }
        }


        //for-nan olanda

        //for (int i = 0; i<employees.Length; i++)
        //    {
        //        if (employees[i].Contains(searchText))
        //        {

        //            result = employees[i];

        //            Console.WriteLine(result);
        //        }
}
    }

