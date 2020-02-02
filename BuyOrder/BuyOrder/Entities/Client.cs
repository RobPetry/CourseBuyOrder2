using System;
using System.Collections.Generic;
using System.Text;

namespace BuyOrder.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirtDate { get; set; }

        public Client(string name, string email, DateTime birtDate)
        {
            Name = name;
            Email = email;
            BirtDate = birtDate;
        }

        public override string ToString()
        {
            return $"Name: {Name} ({BirtDate:dd/MM/yyyy}) - {Email}";
        }
    }
}
