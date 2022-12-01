using MeusLivros.Business.Models.Products;
using MeusLivros.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivros.Infra.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(BookDbContext context) : base(context)
        {
        }

        public async Task<Product> GetProductProvider(Guid id)
            => await Db.Products.AsNoTracking()
                .Include(f => f.Provider)
                .FirstOrDefaultAsync(p => p.Id == id);

        public async Task<IEnumerable<Product>> GetProductsProviders()
            => await Db.Products.AsNoTracking()
                .Include(f => f.Provider)
                .OrderBy(p => p.Name).ToListAsync();

        public async Task<IEnumerable<Product>> GetProductsPerProvider(Guid providerId)
            => await Search(p => p.ProviderId == providerId);
    }
}