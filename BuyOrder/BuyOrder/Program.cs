using BuyOrder.Entities;
using BuyOrder.Entities.Enum;
using System;

namespace BuyOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("BirtDay: ");
            DateTime birtDay = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name,email,birtDay);
            Console.WriteLine("Enter Order data:");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Order order = new Order(client, status);
            Console.Write("How many items to this order?");
            int n = 0;
            int.TryParse(Console.ReadLine(),out n);
            for(int i=0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} Item data:");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                double pPriece= 0.00;
                Console.Write("Product priece: ");
                double.TryParse(Console.ReadLine(),out pPriece);
                int pQuantity = 1;
                Console.Write("Quantity: ");
                int.TryParse(Console.ReadLine(), out pQuantity);
                Product product = new Product(pName, pPriece);
                OrderItem oi = new OrderItem(pQuantity, product);
                order.AddItem(oi);

            }
            Console.WriteLine(order.Total());
        }
    }
}
