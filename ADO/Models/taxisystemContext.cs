using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ADO.Models.Mapping;

namespace ADO.Models
{
    public partial class taxisystemContext : DbContext
    {
        static taxisystemContext()
        {
            Database.SetInitializer<taxisystemContext>(null);
        }

        public taxisystemContext()
            : base("Name=taxisystemContext")
        {
        }

        public DbSet<Bid> Bids { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServicesProvided> ServicesProvideds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BidMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new ProviderMap());
            modelBuilder.Configurations.Add(new ServiceMap());
            modelBuilder.Configurations.Add(new ServiceRequestMap());
            modelBuilder.Configurations.Add(new ServicesProvidedMap());
        }
    }
}
