using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOv2.Models;

namespace ADOv2.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Bid> Bids { get; }
        IRepository<Customer> Customers { get; }
        IRepository<Provider> Providers { get; }
        IRepository<Service> Services { get; }
        IRepository<ServiceRequest> ServiceRequests { get; }
        IRepository<ServicesProvided> ServicesProvided { get; }
        void Commit();
    }
}
