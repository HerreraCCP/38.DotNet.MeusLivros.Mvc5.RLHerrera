using RLHerrera.AspNet.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RLHerrera.AspNet.Business.Models
{
    public interface IProdutosRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);

        Task<IEnumerable<Produto>> ObterProdutosFornecedores();

        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}