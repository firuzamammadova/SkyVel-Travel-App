using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDeals
{
    public class Useful : INotifyPropertyChanged
    {
		public string OutboundLegId { get; set; }
		public string Price { get; set; }
        public string OriginPlace { get; set; }
        public string DestPlace { get; set; }
        public string Destcity { get; set; }
        public string Duration { get; set; }
		public string Departuredate { get; set; }
		public string Departuretime { get; set; }
		public string Arrival { get; set; }
		public string ArrivalDate { get; set; }
		public string Mode { get; set; }
		public string Photo { get; set; }
		public string Deals { get; set; }
		public List<PricingOption> PricingOptions { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(Price));
            }
        }
    }
}
