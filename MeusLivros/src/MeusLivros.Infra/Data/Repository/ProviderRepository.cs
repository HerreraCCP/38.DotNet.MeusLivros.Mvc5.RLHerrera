using MeusLivros.Business.Models.Providers;
using MeusLivros.Infra.Data.Context;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MeusLivros.Infra.Data.Repository
{
    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {
        public ProviderRepository(BookDbContext context) : base(context)
        {
        }

        public async Task<Provider> GetProviderAddress(Guid id)
            => await Db.Providers.AsNoTracking()
                .Include(x => x.Address)
                .FirstOrDefaultAsync(f => f.Id == id);

        public async Task<Provider> GetProviderProductsAddress(Guid id)
            => await Db.Providers.AsNoTracking()
                .Include(f => f.Address)
                .Include(f => f.Products)
                .FirstOrDefaultAsync(f => f.Id == id);

        public override async Task Remove(Guid id)
        {
            var provider = await GetById(id);
            provider.IsActive = false;
            await Update(provider);
        }
        // TODO: Rodrigo: Squad Mine: 2022/11/30: Adicionar a flag IsExcluded pois o ativo/inativo acaba mostrando.
    }
}