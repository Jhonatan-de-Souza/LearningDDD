using DomainDrivenDesign.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DomainDrivenDesign.Infra.Data.EntityConfig
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(p => p.ProductId);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Value)
                .IsRequired();

            HasRequired(p => p.Client)
                .WithMany()
                .HasForeignKey(p => p.ClientId);
        }

    }
}
