using System;
using System.Collections.Generic;
using ADOv2.Interfaces;

namespace ADOv2.Models
{
    public partial class Customer:IEntity
    {
        public Customer()
        {
            this.ServiceRequests = new List<ServiceRequest>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerHouseNumber { get; set; }
        public string CustomerPostcode { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }

        public int Id
        {
            get
            {
                return CustomerId;
            }
        }
    }
}
