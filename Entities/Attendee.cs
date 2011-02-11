using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventbriteNET.Entities
{
    public enum AttendeeGender
    {
        Male,
        Female
    }
    public class Attendee : EntityBase
    {
        public int Id;
        public int EventId;
        public int? TicketId;
        public int? Quantity;
        public string Currency;
        public float? AmountPaid;
        public string Barcode;
        public int? OrderId;
        public string OrderType;
        public DateTime? Created;
        public DateTime? Modified;
        public DateTime? EventDate;
        public string Discount;
        public string Notes;
        public string Email;
        public string Prefix;
        public string FirstName;
        public string LastName;
        public string Suffix;
        public string HomeAddress;
        public string HomeAddress2;
        public string HomeCity;
        public string HomePostalCode;
        public string HomeRegion;
        public string HomeCountry;
        public string HomeCountryCode;
        public string HomePhone;
        public string CellPhone;
        public string ShipAddress;
        public string ShipAddress2;
        public string ShipCity;
        public string ShipPostalCode;
        public string ShipRegion;
        public string ShipCountry;
        public string ShipCountryCode;
        public string WorkAddress;
        public string WorkAddress2;
        public string WorkCity;
        public string WorkPostalCode;
        public string WorkRegion;
        public string WorkCountry;
        public string WorkCountryCode;
        public string WorkPhone;
        public string JobTitle;
        public string Company;
        public string Website;
        public string Blog;
        public AttendeeGender? Gender;
        public DateTime? BirthDate;
        public int? Age;

        public Attendee(EventbriteContext context) : base(context) { }
    }
}
