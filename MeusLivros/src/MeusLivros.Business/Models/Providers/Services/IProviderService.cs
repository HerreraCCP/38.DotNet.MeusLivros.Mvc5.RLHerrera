﻿using System;
using System.Threading.Tasks;

namespace MeusLivros.Business.Models.Providers.Services
{
    public interface IProviderService : IDisposable
    {
        Task Add(Provider provider);
        
        Task Update(Provider provider);

        Task Remove(Guid id);

        Task UpdateAddress(Address address);
    }
}