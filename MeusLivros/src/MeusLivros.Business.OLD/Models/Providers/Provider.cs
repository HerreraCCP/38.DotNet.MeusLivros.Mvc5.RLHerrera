using MeusLivros.Business.Core.Models;
using MeusLivros.Business.Models.Products;
using System.Collections.Generic;

namespace MeusLivros.Business.Models.Providers
{
    public class Provider : Entity
    {
        public string Name { get; set; }
        
        public string Document { get; set; }
        
        public TypeOfProvider TypeOfProvider { get; set; }
        
        public Address Address { get; set; }
        
        public bool IsActive { get; set; }

        /* EF Relations */
        public ICollection<Product> Products { get; set; }
    }
}
