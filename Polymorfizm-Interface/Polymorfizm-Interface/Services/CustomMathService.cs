using Polymorfizm_Interface.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm_Interface.Services
{
    internal class CustomMathService : ICustomMathService
    {
        public int GetNumbersOfSum(int[] nums)
        {
            int sum = 0;
            foreach (var item in nums) 
            {
                sum += item;
            }
            return sum;
        }

        public double PowOfNum(int num, int pow)
        {
            var result = Math.Pow(num, pow);
            return result;
        }



        //public double PowOfNum(int num,int pow)
        //{
        //    return Calculate(num, pow);
        //}


        //private double Calculate(int num,int pow)
        //{
        //    var result = Math.Pow(num, pow);
        //    return result;
        //}

        public void Sum(int a, int b)
        {

            int sum = a + b;
            Console.WriteLine(sum);

        }
    }
}
