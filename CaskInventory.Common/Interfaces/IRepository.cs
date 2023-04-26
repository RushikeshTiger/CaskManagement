using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaskInventory.Common.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(uint id);
        TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool disableTracking = true);
        IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            int index = 0,
            int size = 20,
            bool disableTracking = true,
            CancellationToken cancellationToken = default);
        void Update(TEntity obj);
        void Remove(int id);
        bool Exists(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
        void RemoveRange(IQueryable<TEntity> obj);
        void AddRange(IQueryable<TEntity> obj);
        void UpdateRange(IQueryable<TEntity> obj);
    }
}
