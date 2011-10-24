using System.Collections.Generic;
using EventbriteNET.HttpApi;

namespace EventbriteNET.Entities
{
    public class Organizer : EntityBase
    {
        private long id;
        public long Id
        {
            get
            {
                return this.id;
            }
        }

        private Dictionary<long, Event> events;
        public Dictionary<long, Event> Events
        {
            get
            {
                if (events == null)
                {
                    events = new Dictionary<long, Event>();
                    var eventArray = new OrganizerEventsRequest(this.Id, Context).GetResponse();
                    foreach (var eventEntity in eventArray)
                    {
                        events.Add(eventEntity.Id, eventEntity);
                    }
                }
                return events;
            }
        }

        public Organizer(long id, EventbriteContext context) : base(context)
        {
            this.id = id;
        }

    }
}
