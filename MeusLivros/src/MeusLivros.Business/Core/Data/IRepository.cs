using MeusLivros.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MeusLivros.Business.Core.Data
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity, new()
    {
        Task Add(TEntity entity);

        Task<TEntity> GetById(Guid id);

        Task<List<TEntity>> GetAll(TEntity entity);

        Task Update(TEntity entity);

        Task Remove(Guid id);

        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();
    }
}