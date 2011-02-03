using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventbriteApi.Entities;
using EventbriteApi.Xml;

namespace EventbriteApi.HttpApi
{
    class EventAttendeesRequest : RequestBase
    {
        const string PATH = "event_list_attendees";

        public EventAttendeesRequest(int eventId)
            : base(PATH)
        {
            this.AddGet("id", eventId.ToString());
        }

        public Attendee[] GetResponse()
        {
            return new EventAttendeesBuilder().Build(base.GetResponse());
        }
    }
}
