using MeusLivros.Business.Models.Providers;
using System.Data.Entity.ModelConfiguration;

namespace MeusLivros.Infra.Data.Mappings
{
    public class AddressConfig : EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            HasKey(keyExpression: p => p.Id);

            Property(propertyExpression: c => c.Publicspace)
                .IsRequired()
                .HasMaxLength(200);

            Property(propertyExpression: c => c.Number)
                .IsRequired()
                .HasMaxLength(50);

            Property(propertyExpression: c => c.Zipcode)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(propertyExpression: c => c.Complement)
                .HasMaxLength(250);

            Property(propertyExpression: c => c.Neighborhood)
                .IsRequired();

            Property(propertyExpression: c => c.City)
                .IsRequired();

            Property(propertyExpression: c => c.State)
                .IsRequired();

            ToTable("Addresses");
        }
    }
}