using BuyOrder.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuyOrder.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(Client client, OrderStatus status)
        {
            Client = client;
            Moment = DateTime.Now;
            Status = status;
        }
        public void AddItem(OrderItem item)
        {
            Orders.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Orders.Remove(item);
        }
        public String Total()
        {
            Status = OrderStatus.Processing;
            double total =0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order momment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH/mm/ss"));
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach (OrderItem o in Orders)
            {
                total += o.SubTotal();
                sb.AppendLine(o.ToString());
            }

            sb.Append("Total price: $");
            if(total>0)
                sb.AppendLine(total.ToString("f2"));
            else
                sb.AppendLine("No orders.");
            return sb.ToString();
        }
    }
}
