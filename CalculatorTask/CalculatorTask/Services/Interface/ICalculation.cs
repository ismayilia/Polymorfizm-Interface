using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask.Services.Interface
{
    internal interface ICalculation
    {
        decimal Calculate(decimal a, string operation, decimal b);
    }
}
