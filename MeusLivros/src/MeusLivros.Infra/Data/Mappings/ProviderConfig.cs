using MeusLivros.Business.Models.Providers;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace MeusLivros.Infra.Data.Mappings
{
    public class ProviderConfig : EntityTypeConfiguration<Provider>
    {
        public ProviderConfig()
        {
            HasKey(f => f.Id);

            Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.Document)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnAnnotation("IX_Documento",
                    new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            HasRequired(f => f.Address)
                .WithRequiredPrincipal(e => e.Provider);

            ToTable("Providers");
        }
    }
}