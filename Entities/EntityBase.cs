using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventbriteNET.Entities
{
    public class EntityBase
    {
        public EventbriteContext Context;

        public EntityBase(EventbriteContext context)
        {
            this.Context = context;
        }
    }
}
