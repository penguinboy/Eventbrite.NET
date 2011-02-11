using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventbriteNET.Entities;
using EventbriteNET.HttpApi;

namespace EventbriteNET
{
    public class EventbriteContext
    {
        public string AppKey;
        public string UserKey;
        public string Host = "https://www.eventbrite.com/xml/";

        public EventbriteContext(string appKey, string userKey = null)
        {
            this.AppKey = appKey;
            if (userKey != null)
            {
                this.UserKey = userKey;
            }
        }

        public Organizer GetOrganizer(int id)
        {
            return new Organizer(id, this);
        }

        public Event GetEvent(int id)
        {
            return new EventRequest(id, this).GetResponse();
        }
    }
}
