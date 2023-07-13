using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mo4ur.Class
{
    public class Mo4ur
    {
        public Mo4ur(string name, decimal price, int grams)
        {
            Name = name;
            Price = price;
            Grams = grams;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Grams { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Grams}g - ${Price}";
        }
    }
}
