using CalculatorTask.Helpers;
using CalculatorTask.Services;
using CalculatorTask.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask.Controllers
{
    internal class CalculationController
    {
        private readonly ICalculation _calculation;

        public CalculationController()
        {
            _calculation = new Calculation();
        }

        public void Calculate()
        {
            

            Console.WriteLine("Add number: ");
            decimal a=decimal.Parse(Console.ReadLine());

            Console.WriteLine("Add operation: ");
            Operation: string operation = Console.ReadLine();

            string[] operations = { "+", "-", "*", "/", };

            if (operations.Contains(operation))
            {

                Console.WriteLine("Add number: ");
                B: decimal b=decimal.Parse(Console.ReadLine());

                if (operation=="/" && b==0)
                {
                    Console.WriteLine(CalculateMessages.DvideZero);
                    goto B;
                }
                
                              

                Console.WriteLine(_calculation.Calculate(a, operation, b));

            }
            else
            {
                Console.WriteLine(CalculateMessages.OperationError);
                goto Operation;
            }

            




        }










    }
}
