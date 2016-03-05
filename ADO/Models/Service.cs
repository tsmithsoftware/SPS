using System;
using System.Collections.Generic;

namespace ADO.Models
{
    public partial class Service
    {
        public Service()
        {
            this.ServiceRequests = new List<ServiceRequest>();
            this.ServicesProvideds = new List<ServicesProvided>();
        }

        public int ServiceId { get; set; }
        public string ServiceDescription { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
        public virtual ICollection<ServicesProvided> ServicesProvideds { get; set; }
    }
}
