using System;
using EventbriteNET.Entities;
using System.Xml;
using System.IO;

namespace EventbriteNET.Xml
{
    class TicketBuilder : BuilderBase
    {
        public TicketBuilder(EventbriteContext context) : base(context) { }

        public Ticket Build(string xmlString)
        {
            this.Validate(xmlString);

            var stringReader = new StringReader(xmlString);

            var toReturn = new Ticket(this.Context);

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);

            toReturn.Id = long.Parse(doc.GetElementsByTagName("id")[0].InnerText);
            toReturn.Name = doc.GetElementsByTagName("name")[0].InnerText;
            toReturn.Description = doc.GetElementsByTagName("description")[0].InnerText;
            toReturn.Type = (TicketType)Int32.Parse(doc.GetElementsByTagName("type")[0].InnerText);
            toReturn.Currency = doc.GetElementsByTagName("currency")[0].InnerText;
            toReturn.EndDateTime = DateTime.Parse(doc.GetElementsByTagName("end_date")[0].InnerText);
            
            

            // optional elements
            if (doc.GetElementsByTagName("start_date").Count > 0)
            {
                toReturn.StartDateTime = DateTime.Parse(doc.GetElementsByTagName("start_date")[0].InnerText);
            }
            if (doc.GetElementsByTagName("quantity_available").Count > 0)
            {
                toReturn.QuantityAvailable = Int32.Parse(doc.GetElementsByTagName("quantity_available")[0].InnerText);
            }
            if (doc.GetElementsByTagName("quantity_sold").Count > 0)
            {
                toReturn.QuantitySold = Int32.Parse(doc.GetElementsByTagName("quantity_sold")[0].InnerText);
            }
            if (toReturn.Type == TicketType.FixedPrice)
            {
                toReturn.Price = Decimal.Parse(doc.GetElementsByTagName("price")[0].InnerText);
            }


            return toReturn;
        }
    }
}
