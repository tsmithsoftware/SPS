using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ADOv2.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerID);

            // Properties
            this.Property(t => t.CustomerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CustomerName)
                .HasMaxLength(255);

            this.Property(t => t.CustomerHouseNumber)
                .HasMaxLength(255);

            this.Property(t => t.CustomerPostcode)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Customer");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.CustomerHouseNumber).HasColumnName("CustomerHouseNumber");
            this.Property(t => t.CustomerPostcode).HasColumnName("CustomerPostcode");
        }
    }
}
