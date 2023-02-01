using RLHerrera.AspNet.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace RLHerrera.AspNet.Business.Models
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}