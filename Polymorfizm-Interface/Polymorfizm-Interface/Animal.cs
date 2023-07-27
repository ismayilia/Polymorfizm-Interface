using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm_Interface
{
    internal abstract class Animal
    {
        public readonly string Address;
        public string Phone { get; set; }
        public string Name { get; set; }



        public abstract void Sound();
        public virtual void Eating()
        {
            Console.WriteLine("Animal eating ");
        }
    }
}
