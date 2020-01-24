using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSalesWebApp.Models
{
    public class Registration
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public Ticket ticket { get; set; }

    }

    public class Ticket
    {
        public string TicketType { get; set; }
        public decimal Price { get; set; }

    }
}
