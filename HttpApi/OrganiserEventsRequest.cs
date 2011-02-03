using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventbriteApi.Entities;
using EventbriteApi.Xml;

namespace EventbriteApi.HttpApi
{
    public class OrganiserEventsRequest : RequestBase
    {
        const string PATH = "organizer_list_events";

        public OrganiserEventsRequest(int organiserId)
            : base(PATH)
        {
            this.AddGet("id", organiserId.ToString());
        }

        public Event[] GetResponse()
        {
            return new OrganisationEventsBuilder().Build(base.GetResponse());
        }
    }
}
