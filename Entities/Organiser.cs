using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventbriteNET.HttpApi;

namespace EventbriteNET.Entities
{
    public class Organiser
    {
        public int Id;

        private Dictionary<int, Event> events;
        public Dictionary<int, Event> Events
        {
            get
            {
                if (events == null)
                {
                    events = new Dictionary<int, Event>();
                    var eventArray = new OrganiserEventsRequest(this.Id).GetResponse();
                    foreach (var eventEntity in eventArray)
                    {
                        events.Add(eventEntity.Id, eventEntity);
                    }
                }
                return events;
            }
        }

        public Organiser(int id)
        {
            this.Id = id;
        }

    }
}
