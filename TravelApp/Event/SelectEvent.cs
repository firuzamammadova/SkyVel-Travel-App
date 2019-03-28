using FindDeals;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.Event
{
    public class SelectEvent : PubSubEvent<SelectEventArgs>
    {
    }
    public class SelectEventArgs
    {
        public Useful sl { get; set; }
        public List<Agent> ag { get; set; }
    }
}
