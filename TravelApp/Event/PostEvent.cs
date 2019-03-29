using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Model;

namespace TravelApp.Event
{
    public class PostEvent : PubSubEvent<PostEventAggregators>
    {
    }

    public class PostEventAggregators
    {
        public string ms { get; set; }
        public Flight basicflightinfo { get; set; }
    }
}
