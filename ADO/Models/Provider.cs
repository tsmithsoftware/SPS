using System;
using System.Collections.Generic;

namespace ADO.Models
{
    public partial class Provider
    {
        public Provider()
        {
            this.Bids = new List<Bid>();
            this.ServicesProvideds = new List<ServicesProvided>();
        }

        public int ProviderId { get; set; }
        public string PoviderPostCode { get; set; }
        public string ProviderName { get; set; }
        public virtual ICollection<Bid> Bids { get; set; }
        public virtual ICollection<ServicesProvided> ServicesProvideds { get; set; }
    }
}
