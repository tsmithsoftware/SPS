using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADO.Models.Mapping
{
    public class ServiceMap : EntityTypeConfiguration<Service>
    {
        public ServiceMap()
        {
            // Primary Key
            this.HasKey(t => t.ServiceId);

            // Properties
            this.Property(t => t.ServiceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ServiceDescription)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Service");
            this.Property(t => t.ServiceId).HasColumnName("ServiceId");
            this.Property(t => t.ServiceDescription).HasColumnName("ServiceDescription");
        }
    }
}
