using EventbriteNET.Entities;
using EventbriteNET.Xml;

namespace EventbriteNET.HttpApi
{
    class EventAttendeesRequest : RequestBase
    {
        const string PATH = "event_list_attendees";

        public EventAttendeesRequest(long eventId, EventbriteContext context)
            : base(PATH, context)
        {
            this.AddGet("id", eventId.ToString());
        }

        public Attendee[] GetResponse()
        {
            return new EventAttendeesBuilder(this.Context).Build(base.GetResponse());
        }
    }
}
