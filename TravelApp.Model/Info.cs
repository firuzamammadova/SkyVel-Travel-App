using System.Collections.Generic;

namespace FindDeals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public class Info
    {
        public string SessionKey { get; set; }
        public Dictionary<string, string> Query { get; set; }
        public List<Itinerary> Itineraries { get; set; }
        public List<Leg> Legs { get; set; }
        public List<Segment> Segments { get; set; }
        public List<Carrier> Carriers { get; set; }
        public List<Agent> Agents { get; set; }
        public List<Place> Places { get; set; }


    }
}
