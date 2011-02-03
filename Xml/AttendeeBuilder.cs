using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventbriteApi.Entities;
using System.IO;
using System.Xml;

namespace EventbriteApi.Xml
{
    public class AttendeeBuilder : BuilderBase
    {
        public Attendee Build(string xmlString)
        {
            var stringReader = new StringReader(xmlString);

            var toReturn = new Attendee();

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);

            toReturn.Id = TryGetElementIntValue("id", doc);
            toReturn.EventId = TryGetElementIntValue("event_id", doc);
            toReturn.TicketId = TryGetElementNullableIntValue("ticket_id", doc);
            toReturn.Quantity = TryGetElementNullableIntValue("quantity", doc);
            toReturn.Currency = TryGetElementValue("currency", doc);
            toReturn.AmountPaid = TryGetElementNullableFloatValue("amount_paid", doc);
            toReturn.Barcode = TryGetElementValue("barcode", doc);
            toReturn.OrderId = TryGetElementNullableIntValue("order_id", doc);
            toReturn.OrderType = TryGetElementValue("order_type", doc);
            toReturn.Created = TryGetElementDateTimeValue("created", doc);
            toReturn.Modified = TryGetElementDateTimeValue("modified", doc);
            toReturn.EventDate = TryGetElementDateTimeValue("event_date", doc);
            toReturn.Discount = TryGetElementValue("discount", doc);
            toReturn.Notes = TryGetElementValue("notes", doc);
            toReturn.Email = TryGetElementValue("email", doc);
            toReturn.Prefix = TryGetElementValue("prefix", doc);
            toReturn.FirstName = TryGetElementValue("first_name", doc);
            toReturn.LastName = TryGetElementValue("last_name", doc);
            toReturn.Suffix = TryGetElementValue("suffix", doc);
            toReturn.HomeAddress = TryGetElementValue("home_address", doc);
            toReturn.HomeAddress2 = TryGetElementValue("home_address_2", doc);
            toReturn.HomeCity = TryGetElementValue("home_city", doc);
            toReturn.HomePostalCode = TryGetElementValue("home_postal_code", doc);
            toReturn.HomeRegion = TryGetElementValue("home_region", doc);
            toReturn.HomeCountry = TryGetElementValue("home_country", doc);
            toReturn.HomeCountryCode = TryGetElementValue("home_country_code", doc);
            toReturn.HomePhone = TryGetElementValue("home_phone", doc);
            toReturn.CellPhone = TryGetElementValue("cell_phone", doc);
            toReturn.ShipAddress = TryGetElementValue("ship_address", doc);
            toReturn.ShipAddress2 = TryGetElementValue("ship_address_2", doc);
            toReturn.ShipCity = TryGetElementValue("ship_city", doc);
            toReturn.ShipPostalCode = TryGetElementValue("ship_postal_code", doc);
            toReturn.ShipRegion = TryGetElementValue("ship_region", doc);
            toReturn.ShipCountry = TryGetElementValue("ship_country", doc);
            toReturn.ShipCountryCode = TryGetElementValue("ship_country_code", doc);
            toReturn.WorkAddress = TryGetElementValue("work_address", doc);
            toReturn.WorkAddress2 = TryGetElementValue("work_address_2", doc);
            toReturn.WorkCity = TryGetElementValue("work_city", doc);
            toReturn.WorkPostalCode = TryGetElementValue("work_postal_code", doc);
            toReturn.WorkRegion = TryGetElementValue("work_region", doc);
            toReturn.WorkCountry = TryGetElementValue("work_country", doc);
            toReturn.WorkCountryCode = TryGetElementValue("work_country_code", doc);
            toReturn.WorkPhone = TryGetElementValue("work_phone", doc);
            toReturn.JobTitle = TryGetElementValue("job_title", doc);
            toReturn.Company = TryGetElementValue("company", doc);
            toReturn.Website = TryGetElementValue("website", doc);
            toReturn.Blog = TryGetElementValue("blog", doc);
            toReturn.BirthDate = TryGetElementDateTimeValue("birth_date", doc);
            toReturn.Age = TryGetElementNullableIntValue("age", doc);

            var gender = TryGetElementNullableIntValue("gender", doc);
            if (gender != null)
            {
                toReturn.Gender = (AttendeeGender)gender;
            }

            return toReturn;
        }
    }
}
