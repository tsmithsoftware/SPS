using System;
using System.Collections.Generic;
using ADOv2.Interfaces;

namespace ADOv2.Models
{
    public partial class Bid:IEntity
    {
        public int BidId { get; set; }
        public int ProviderId { get; set; }
        public int ServiceRequestId { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual ServiceRequest ServiceRequest { get; set; }

        public int Id
        {
            get
            {
                return BidId;
            }
        }
    }
}
