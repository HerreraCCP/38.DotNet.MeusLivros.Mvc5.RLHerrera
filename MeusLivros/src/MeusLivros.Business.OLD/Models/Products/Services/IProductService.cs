using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusLivros.Business.Models.Products.Services
{
    public interface IProductService : IDisposable
    {
        Task Add(Product product);
        
        Task Update(Product product);
        
        Task Remove(Guid id);
    }
}