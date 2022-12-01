using MeusLivros.Business.Models.Providers;
using MeusLivros.Infra.Data.Context;
using System;
using System.Threading.Tasks;

namespace MeusLivros.Infra.Data.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(BookDbContext context)
            : base(context)
        {
        }

        public async Task<Address> GetAddressByProvider(Guid providerId)
        {
            // return await Db.Addresses.AsNoTracking().FirstOrDefaultAsync(p => p.Id == providerId);
            return await GetById(providerId);
        }
    }
}