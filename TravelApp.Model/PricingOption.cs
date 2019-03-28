using System.Collections.Generic;

namespace FindDeals
{
    public class PricingOption
    {
        public List<int> Agents { get; set; }
        public string QuoteAgeInMinutes { get; set; }
        public string Price { get; set; }
        public string DeeplinkUrl { get; set; }
    }
}
