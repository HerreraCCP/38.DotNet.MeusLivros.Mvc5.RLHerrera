using MeusLivros.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace MeusLivros.Business.Models.Providers
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<Address> GetAddressByProvider(Guid providerId);
    }
}