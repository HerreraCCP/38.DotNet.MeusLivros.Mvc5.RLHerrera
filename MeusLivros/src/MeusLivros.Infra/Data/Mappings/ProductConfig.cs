using MeusLivros.Business.Models.Products;
using System.Data.Entity.ModelConfiguration;

namespace MeusLivros.Infra.Data.Mappings
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(1000);

            Property(p => p.Image)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(p => p.Provider)
                .WithMany(f => f.Products)
                .HasForeignKey(p => p.ProviderId);

            ToTable("Products");
        }
    }
}