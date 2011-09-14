using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventbriteNET.HttpApi;

namespace EventbriteNET.Entities
{
    public class Organizer : EntityBase
    {
        private int id;
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        private Dictionary<int64, Event> events;
        public Dictionary<int64, Event> Events
        {
            get
            {
                if (events == null)
                {
                    events = new Dictionary<int64, Event>();
                    var eventArray = new OrganizerEventsRequest(this.Id, Context).GetResponse();
                    foreach (var eventEntity in eventArray)
                    {
                        events.Add(eventEntity.Id, eventEntity);
                    }
                }
                return events;
            }
        }

        public Organizer(int id, EventbriteContext context) : base(context)
        {
            this.id = id;
        }

    }
}
