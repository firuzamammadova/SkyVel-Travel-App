using System.Collections.Generic;
using System.ComponentModel;

namespace FindDeals
{
    public class Itinerary : INotifyPropertyChanged
    {
        public string OutboundLegId { get; set; }
        public string InboundLegId { get; set; }
        public List<PricingOption> PricingOptions { get; set; }
        public BookingDetailsLink BookingDetailsLink { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(OutboundLegId));
            }
        }
    }
}
