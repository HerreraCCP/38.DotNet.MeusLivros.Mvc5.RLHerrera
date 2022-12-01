using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MeusLivros.Business.Core.Models;

namespace MeusLivros.Business.Core.Data
{
    public interface IRepository<TEntity> 
        : IDisposable where TEntity : Entity, new()
    {
        Task AddAsync(TEntity entity);

        Task<TEntity> GetByIdAsync(Guid id);

        Task<List<TEntity>> GetAllAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChangesAsync();
    }
}