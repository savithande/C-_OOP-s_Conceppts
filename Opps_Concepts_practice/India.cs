using System;
using System.Collections.Generic;
using System.Text;

namespace Opps_Concepts_practice
{
    abstract class India
    {
        //Regular Method
        public virtual void capital()
        {
            Console.WriteLine("The capital of India is Delhi");
        }

        //abstract method
        public abstract void nationalFlower();
    }
}
