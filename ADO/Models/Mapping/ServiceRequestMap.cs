using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADO.Models.Mapping
{
    public class ServiceRequestMap : EntityTypeConfiguration<ServiceRequest>
    {
        public ServiceRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.ServiceRequestId);

            // Properties
            this.Property(t => t.ServiceRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ServiceRequest");
            this.Property(t => t.ServiceRequestId).HasColumnName("ServiceRequestId");
            this.Property(t => t.CustomerId).HasColumnName("CustomerId");
            this.Property(t => t.ServiceId).HasColumnName("ServiceId");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.Customer)
                .WithMany(t => t.ServiceRequests)
                .HasForeignKey(d => d.CustomerId);
            this.HasOptional(t => t.Service)
                .WithMany(t => t.ServiceRequests)
                .HasForeignKey(d => d.ServiceId);

        }
    }
}
