using System;
using System.Collections.Generic;
using ADOv2.Interfaces;

namespace ADOv2.Models
{
    public partial class Provider:IEntity
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

        public int Id
        {
            get
            {
                return ProviderId;
            }
        }
    }
}
