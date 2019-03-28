using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.Model
{
    public class Flight
    {
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public bool Trip { get; set; }
        public List<Passenger> Passengers { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
