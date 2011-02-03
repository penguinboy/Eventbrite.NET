using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventbriteNET.Entities;

namespace EventbriteNET.Xml
{
    interface IBuilder
    {
        IEntity Build();
    }
}
