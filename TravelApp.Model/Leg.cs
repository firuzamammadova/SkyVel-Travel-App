using System.Collections.Generic;

namespace FindDeals
{
    public class Leg
    {
        public string Id { get; set; }
        public List<int> SegmentIds { get; set; }
        public int OriginStation { get; set; }
        public int DestinationStation { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int Duration { get; set; }
        public string JourneyMode { get; set; }
        public List<int> Stops { get; set; }
        public List<int> Carriers { get; set; }
        public List<int> OperatingCarriers { get; set; }

        public string Directionality { get; set; }
        public List<FlightNumbe> FlightNumbers { get; set; }


    }
}
