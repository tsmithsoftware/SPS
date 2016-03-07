using System;
using System.Collections.Generic;
using ADOv2.Interfaces;
using ADOv2.Models;

namespace ADOv2.Models
{
    public partial class Service:IEntity
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

        public int Id
        {
            get { return ServiceId; }
        }
    }
}
