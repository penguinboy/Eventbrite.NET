using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventbriteApi.Entities;
using System.IO;
using System.Xml;

namespace EventbriteApi.Xml
{
    class EventAttendeesBuilder
    {
        public Attendee[] Build(string xmlString)
        {
            var stringReader = new StringReader(xmlString);
            var toReturn = new List<Attendee>();

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);

            var attendees = doc.GetElementsByTagName("attendee");
            var builder = new AttendeeBuilder();
            foreach (XmlNode attendeeNode in attendees)
            {
                var attendee = builder.Build(attendeeNode.OuterXml);
                toReturn.Add(attendee);
            }

            return toReturn.ToArray();
        }
    }
}
