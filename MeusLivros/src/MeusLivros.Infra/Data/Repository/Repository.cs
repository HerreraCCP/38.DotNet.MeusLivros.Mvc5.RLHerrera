using MeusLivros.Business.Core.Data;
using MeusLivros.Business.Core.Models;
using MeusLivros.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
// ReSharper disable HeapView.BoxingAllocation

namespace MeusLivros.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly BookDbContext Db;
        private readonly DbSet<TEntity> _dbSet;

        protected Repository(BookDbContext db)
        {
            Db = db;
            _dbSet = Db.Set<TEntity>();
        }

        public virtual async Task<TEntity> GetById(Guid id)
            => await _dbSet.FindAsync(id);

        public virtual async Task<List<TEntity>> GetAll(TEntity entity)
            => await _dbSet.ToListAsync();

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
            => await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        public async Task<int> SaveChanges() 
            => await Db.SaveChangesAsync();

        public virtual async Task Add(TEntity entity)
        {
            _dbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Update(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            await SaveChanges();
        }

        public virtual async Task Remove(Guid id)
        {
            Db.Entry(new TEntity { Id = id }).State = EntityState.Deleted;
            await SaveChanges();
        }

        public void Dispose() => Db?.Dispose();
    }
}