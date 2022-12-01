using MeusLivros.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace MeusLivros.Business.Models.Providers
{
    public interface IProviderRepository : IRepository<Provider>
    {
        Task<Provider> GetProviderAddress(Guid id);

        Task<Provider> GetProviderProductsAddress(Guid id);
    }
}