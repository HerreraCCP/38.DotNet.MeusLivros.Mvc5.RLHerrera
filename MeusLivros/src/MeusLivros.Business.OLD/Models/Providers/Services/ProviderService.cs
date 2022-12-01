using MeusLivros.Business.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivros.Business.Models.Providers.Services
{
    public class ProviderService : BaseService, IProviderService
    {
        private readonly IProviderRepository _fornecedorRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public Task Add(Provider provider)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Provider provider)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAddress(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
