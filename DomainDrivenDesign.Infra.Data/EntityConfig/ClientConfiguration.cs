using DomainDrivenDesign.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DomainDrivenDesign.Infra.Data.EntityConfig
{
    class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(c => c.ClientId);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Surname)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();



        }
    }
}
