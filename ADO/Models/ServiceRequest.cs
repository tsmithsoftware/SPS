using System;
using System.Collections.Generic;

namespace ADO.Models
{
    public partial class ServiceRequest
    {
        public ServiceRequest()
        {
            this.Bids = new List<Bid>();
        }

        public int ServiceRequestId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Bid> Bids { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Service Service { get; set; }
    }
}
