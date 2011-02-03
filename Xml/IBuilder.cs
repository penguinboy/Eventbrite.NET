using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventbriteApi.Entities;

namespace EventbriteApi.Xml
{
    interface IBuilder
    {
        IEntity Build();
    }
}
