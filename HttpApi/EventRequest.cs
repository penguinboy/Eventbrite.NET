using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventbriteNET.Entities;
using EventbriteNET.Xml;

namespace EventbriteNET.HttpApi
{
    class EventRequest : RequestBase
    {
        const string PATH = "event_get";

        public EventRequest(int id, EventbriteContext context)
            : base(PATH, context)
        {
            this.AddGet("id", id.ToString());
        }

        public Event GetResponse()
        {
            return new EventBuilder(this.Context).Build(base.GetResponse());
        }
    }
}
