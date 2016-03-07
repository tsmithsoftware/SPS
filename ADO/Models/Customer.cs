using System;
using System.Collections.Generic;

namespace ADO.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.ServiceRequests = new List<ServiceRequest>();
        }

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerHouseNumber { get; set; }
        public string CustomerPostcode { get; set; }
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }
    }
}
