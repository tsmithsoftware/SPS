using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADOv2.Models.Mapping
{
    public class ServicesProvidedMap : EntityTypeConfiguration<ServicesProvided>
    {
        public ServicesProvidedMap()
        {
            // Primary Key
            this.HasKey(t => t.LinkId);

            // Properties
            this.Property(t => t.LinkId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ServicesProvided");
            this.Property(t => t.LinkId).HasColumnName("LinkId");
            this.Property(t => t.ProviderId).HasColumnName("ProviderId");
            this.Property(t => t.ServiceId).HasColumnName("ServiceId");

            // Relationships
            this.HasOptional(t => t.Provider)
                .WithMany(t => t.ServicesProvideds)
                .HasForeignKey(d => d.ProviderId);
            this.HasOptional(t => t.Service)
                .WithMany(t => t.ServicesProvideds)
                .HasForeignKey(d => d.ServiceId);

        }
    }
}
