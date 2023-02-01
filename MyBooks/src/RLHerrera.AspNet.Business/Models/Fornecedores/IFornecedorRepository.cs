using System;
using System.Threading.Tasks;
using RLHerrera.AspNet.Business.Core.Data;

namespace RLHerrera.AspNet.Business.Models
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);

        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}