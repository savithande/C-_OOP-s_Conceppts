using System;
using System.Collections.Generic;
using System.Text;

namespace Opps_Concepts_practice
{
    class Dog : Animal
    {
        public override void animalName()
        {
            Console.WriteLine("Animal name is Dog");
        }
        public override void animalSound()
        {
            Console.WriteLine("Bow Bow!");
        }
    }
}
