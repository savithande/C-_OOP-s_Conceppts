using System;
using System.Collections.Generic;
using System.Text;

namespace Opps_Concepts_practice
{
    class Lion : Animal
    {
        public override void animalName()
        {
            Console.WriteLine("Animal name is : Lion");
        }

        public override void animalSound()
        {
            Console.WriteLine("roar, growl!");
        }
    }
}
