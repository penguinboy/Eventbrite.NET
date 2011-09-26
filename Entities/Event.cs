using System;
using System.Collections.Generic;
using EventbriteNET.HttpApi;

namespace EventbriteNET.Entities
{
    public class Event : EntityBase
    {
        public long Id;
        public string Title;
        public string Description;
        public DateTime StartDateTime;
        public DateTime EndDateTime;
        public DateTime Created;
        public DateTime Modified;

        public Dictionary<long, Ticket> Tickets = new Dictionary<long, Ticket>();

        private List<Attendee> attendees;
        public List<Attendee> Attendees
        {
            get
            {
                if (this.attendees == null)
                {
                    this.attendees = new List<Attendee>();
                    this.attendees.AddRange(new EventAttendeesRequest(this.Id, Context).GetResponse());
                }
                return attendees;
            }
        }

        public Event(EventbriteContext context) : base(context) { }
    }
}
