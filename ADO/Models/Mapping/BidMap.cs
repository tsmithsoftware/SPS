using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADO.Models.Mapping
{
    public class BidMap : EntityTypeConfiguration<Bid>
    {
        public BidMap()
        {
            // Primary Key
            this.HasKey(t => t.BidId);

            // Properties
            this.Property(t => t.BidId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Bid");
            this.Property(t => t.BidId).HasColumnName("BidId");
            this.Property(t => t.ProviderId).HasColumnName("ProviderId");
            this.Property(t => t.ServiceRequestId).HasColumnName("ServiceRequestId");

            // Relationships
            this.HasRequired(t => t.Provider)
                .WithMany(t => t.Bids)
                .HasForeignKey(d => d.ProviderId);
            this.HasRequired(t => t.ServiceRequest)
                .WithMany(t => t.Bids)
                .HasForeignKey(d => d.ServiceRequestId);

        }
    }
}
