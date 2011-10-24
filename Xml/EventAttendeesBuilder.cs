using System;
using System.Collections.Generic;
using EventbriteNET.Entities;
using System.IO;
using System.Xml;

namespace EventbriteNET.Xml
{
    class EventAttendeesBuilder : BuilderBase
    {
        public EventAttendeesBuilder(EventbriteContext context) : base(context) { }

        public Attendee[] Build(string xmlString)
        {
            try
            {
                this.Validate(xmlString);
            }
            catch (Exception e)
            {
                return new Attendee[] { };
            }

            var stringReader = new StringReader(xmlString);
            var toReturn = new List<Attendee>();

            var doc = new XmlDocument();
            doc.LoadXml(xmlString);

            var attendees = doc.GetElementsByTagName("attendee");
            var builder = new AttendeeBuilder(this.Context);
            foreach (XmlNode attendeeNode in attendees)
            {
                var attendee = builder.Build(attendeeNode.OuterXml);
                toReturn.Add(attendee);
            }

            return toReturn.ToArray();
        }
    }
}
