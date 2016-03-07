using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADO.Models.Mapping
{
    public class ProviderMap : EntityTypeConfiguration<Provider>
    {
        public ProviderMap()
        {
            // Primary Key
            this.HasKey(t => t.ProviderId);

            // Properties
            this.Property(t => t.ProviderId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PoviderPostCode)
                .HasMaxLength(255);

            this.Property(t => t.ProviderName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Provider");
            this.Property(t => t.ProviderId).HasColumnName("ProviderId");
            this.Property(t => t.PoviderPostCode).HasColumnName("PoviderPostCode");
            this.Property(t => t.ProviderName).HasColumnName("ProviderName");
        }
    }
}
