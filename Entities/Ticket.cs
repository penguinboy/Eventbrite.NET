using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventbriteApi.Entities
{
    public enum TicketType
    {
        FixedPrice,
        Donation
    }
    public class Ticket
    {
        public int Id;
        public string Name;
        public string Description;
        public TicketType Type;
        public string Currency;
        public float Price;
        public DateTime? StartDateTime;
        public DateTime EndDateTime;
        public int? QuantityAvailable;
        public int? QuantitySold;
    }
}
