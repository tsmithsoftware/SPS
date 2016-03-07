using System;
using System.Collections.Generic;

namespace ADO.Models
{
    public partial class Bid
    {
        public int BidId { get; set; }
        public int ProviderId { get; set; }
        public int ServiceRequestId { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual ServiceRequest ServiceRequest { get; set; }
    }
}
