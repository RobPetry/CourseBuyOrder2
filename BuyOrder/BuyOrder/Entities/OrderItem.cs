using System;
using System.Collections.Generic;
using System.Text;

namespace BuyOrder.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Priece { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Priece = product.Priece;
        }

        public double SubTotal()
        {
            return Quantity * Priece;
        }
        public override string ToString()
        {
            return $"{Product.Name}, ${Priece:f2}, Quantity {Quantity}, SubTotal: ${SubTotal():f2}";
        }
    }
}
