using System;
using System.Collections.Generic;
using System.Text;

namespace BuyOrder.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Priece { get; set; }

        public Product(string name, double priece)
        {
            Name = name;
            Priece = priece;
        }
    }
}
