using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizm_Interface
{
    internal class Bird : Animal
    {
        public Bird()
        {
            Console.WriteLine("Hello bird");
            
        }

        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }

        //public int Age { get; set; }

        
        public override void Eating()
        {
            Console.WriteLine("Bird eating");
        }
    }
}
