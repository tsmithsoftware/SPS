using System;
using System.Collections.Generic;
using ADOv2.Interfaces;

namespace ADOv2.Models
{
    public partial class ServiceRequest:IEntity
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

        public int Id
        {
            get { return ServiceRequestId;}
        }
    }
}
