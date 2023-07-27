using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm_Interface.Services.Interfaces
{
    internal interface ICustomMathService
    {
        void Sum(int a, int b);
        int GetNumbersOfSum(int[] nums);
        double PowOfNum(int num, int pow);
    }
}
