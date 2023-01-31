using System.Collections.Generic;
using RLHerrera.AspNet.Business.Core.Models;

namespace RLHerrera.AspNet.Business.Models
{
    public class Fornecedor : Entity
    {

        public string Nome { get; set; }

        public string Documento { get; set; }

        public TipoFornecedor TipoFornecedor { get; set; }

        public Endereco Endereco { get; set; }

        public bool Ativo { get; set; }
        
        /* EF Relations */
        public ICollection<Produto> Produtos { get; set; }
    }
}