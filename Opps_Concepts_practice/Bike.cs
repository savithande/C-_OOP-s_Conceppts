using System;
using System.Collections.Generic;
using System.Text;

namespace Opps_Concepts_practice
{
    class Bike : Vehicle
    {
        public string model = "Royal Enfield";
        public int cost = 150000;
        public string color = "Black";

        public void hornSound()
        {
            Console.WriteLine("peem, peem!");
        }
    }
}
