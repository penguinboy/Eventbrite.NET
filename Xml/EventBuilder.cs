using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using EventbriteApi.Entities;
using System.IO;

namespace EventbriteApi.Xml
{
    public class EventBuilder
    {
        public Event Build(string xmlString)
        {
            var stringReader = new StringReader(xmlString);

            var toReturn = new Event();

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);

            toReturn.Id = Int32.Parse(doc.GetElementsByTagName("id")[0].InnerText);
            toReturn.Title = doc.GetElementsByTagName("title")[0].InnerText;
            toReturn.Description = doc.GetElementsByTagName("description")[0].InnerText; ;
            toReturn.StartDateTime = DateTime.Parse(doc.GetElementsByTagName("start_date")[0].InnerText);
            toReturn.EndDateTime = DateTime.Parse(doc.GetElementsByTagName("end_date")[0].InnerText);
            toReturn.Created = DateTime.Parse(doc.GetElementsByTagName("created")[0].InnerText);
            toReturn.Modified = DateTime.Parse(doc.GetElementsByTagName("modified")[0].InnerText);

            var tickets = doc.GetElementsByTagName("ticket");
            var builder = new TicketBuilder();
            foreach (XmlNode ticketNode in tickets)
            {
                var ticket = builder.Build(ticketNode.OuterXml);
                toReturn.Tickets.Add(ticket.Id, ticket);
            }


            return toReturn;
        }
    }
}
