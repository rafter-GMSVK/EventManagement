using System.ComponentModel.DataAnnotations.Schema;

namespace EventManagement.Models
{
    public class Ticket
    {
       

        public int TicketId { get; set; }
        public int Price { get; set; }
        public int TicketQuantity { get; set; }     
        public string TicketOwner { get; set; }
        public int EventId { get; set; }

    }

}
