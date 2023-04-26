using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using CaskInventory.Common.Interfaces;
using System.Linq.Expressions;
using CaskInventory.Data.Entities;

namespace CaskInventory.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly CaskdbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(CaskdbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        public void AddRange(IQueryable<TEntity> obj)
        {
            _dbSet.AddRange(obj);
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual bool Exists(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Any(predicate);
        }

        public virtual TEntity GetById(uint id)
        {
            return _dbSet.Find(id);
        }

        public virtual TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool disableTracking = true)
        {
            IQueryable<TEntity> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return orderBy(query).FirstOrDefault();
            return query.FirstOrDefault();
        }

        public virtual IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, int index = 0, int size = 20, bool disableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return orderBy(query);
            return query;
        }

        public virtual void Remove(int id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }

        public void RemoveRange(IQueryable<TEntity> obj)
        {
            _dbSet.RemoveRange(obj);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            _dbSet.UpdateRange(obj);
        }

        public void UpdateRange(IQueryable<TEntity> obj)
        {
            _dbSet.UpdateRange(obj);
        }
    }
}
