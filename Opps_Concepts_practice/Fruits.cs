using System;
using System.Collections.Generic;
using System.Text;

namespace Opps_Concepts_practice
{
    class Fruits
    {
        private string name;
        public string colour;
        protected string taste;
        internal int weight;

        public Fruits()
        {
            name = "Apple";
            colour = "Green";
            taste = "sweet";
            weight = 20;
        }
        public void aboutFruits()
        {
            Console.WriteLine(name);
            Console.WriteLine(weight);
        }
    }
}
