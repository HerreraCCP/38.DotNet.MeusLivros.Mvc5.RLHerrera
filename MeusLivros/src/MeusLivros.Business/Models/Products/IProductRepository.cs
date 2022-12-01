using MeusLivros.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeusLivros.Business.Models.Products
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsPerProvider(Guid providerId);
        
        Task<IEnumerable<Product>> GetProductsProviders();
        
        Task<Product> GetProductProvider(Guid id);
    }
}