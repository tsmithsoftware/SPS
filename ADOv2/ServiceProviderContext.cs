using ADOv2.Models;
using System.Data.Entity;
namespace ADOv2
{
    public class ServiceProviderContext : DbContext
    {
        public ServiceProviderContext()
            : base("name=ServiceProviderContext")
        {
        }
        public virtual DbSet<Bid> Bids { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceRequest> SericeRequests { get; set; }
        public virtual DbSet<ServicesProvided> ServicesProvided { get; set; }
    }
}