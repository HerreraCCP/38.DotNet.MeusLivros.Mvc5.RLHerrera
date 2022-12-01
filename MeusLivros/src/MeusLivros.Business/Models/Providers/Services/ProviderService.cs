using MeusLivros.Business.Core.Services;
using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using MeusLivros.Business.Core.Notifications;
using MeusLivros.Business.Models.Providers.Validations;

namespace MeusLivros.Business.Models.Providers.Services
{
    public class ProviderService : BaseService, IProviderService
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IAddressRepository _addressRepository;

        public ProviderService(IProviderRepository providerRepository,
            IAddressRepository addressRepository,
            INotifier notifier) : base(notifier)
        {
            _providerRepository = providerRepository;
            _addressRepository = addressRepository;
        }

        public async Task Add(Provider provider)
        {
            if (ExecuteValidations(new ProviderValidation(), provider) ||
                !ExecuteValidations(new AddressValidation(), provider.Address)) return;

            if (await ProviderIsExist(provider)) return;

            await _providerRepository.Add(provider);
        }

        public async Task Update(Provider provider)
        {
            if (ExecuteValidations(new ProviderValidation(), provider)) return;
            if (await ProviderIsExist(provider)) return;
            await _providerRepository.Update(provider);
        }

        public async Task Remove(Guid id)
        {
            var provider = await _providerRepository.GetProviderProductsAddress(id);
            if (provider.Products.Any()) return;

            if (provider.Address != null) await _addressRepository.Remove(provider.Address.Id);

            await _providerRepository.Remove(id);
        }

        public async Task UpdateAddress(Address address)
        {
            if (!ExecuteValidations(new AddressValidation(), address)) return;
            await _addressRepository.Update(address);
        }

        private async Task<bool> ProviderIsExist(Provider provider)
        {
            var actualProvider =
                await _providerRepository.Search(p => p.Document == provider.Document && p.Id != provider.Id);

            return actualProvider.Any();
        }

        public void Dispose()
        {
            _providerRepository?.Dispose();
            _addressRepository?.Dispose();
        }
    }
}