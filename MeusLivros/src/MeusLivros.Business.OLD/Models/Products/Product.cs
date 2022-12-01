using MeusLivros.Business.Core.Models;
using MeusLivros.Business.Models.Providers;
using System;

namespace MeusLivros.Business.Models.Products
{
    public class Product : Entity
    {
        public Guid ProviderId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public decimal Value { get; set; }

        public DateTime CreatedIn { get; set; }

        public bool IsActive { get; set; }

        /* EF Relations */ 
        public Provider Provider { get; set; }
    }
}