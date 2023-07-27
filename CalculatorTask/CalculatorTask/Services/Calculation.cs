using CalculatorTask.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask.Services
{
    internal class Calculation : ICalculation
    {
       

        public decimal Calculate(decimal a, string operation, decimal b)
        {
            decimal result;


            switch (operation)
            {
                case "+":
                    result = a + b;
                    return result;
                    break;
                case "-":
                    result = a - b;
                    return result;
                    break;
                case "*":
                    result = a * b;
                    return result;
                    break;
                case "/":
                    result = a / b;
                    return result;
                    break;

            }

            return 0;
        }
    }
}
