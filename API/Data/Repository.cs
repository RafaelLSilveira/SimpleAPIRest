using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public abstract class Repository<TContext, TEntity>
        where TContext : DbContext 
        where TEntity : class
    {
        protected readonly TContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(
            TContext db
        )
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            var result = QueryDb();

            return result;
        }

        public virtual IQueryable<TEntity> QueryDb()
        {
            return QueryDbBase().AsNoTracking();
        }

        private IQueryable<TEntity> QueryDbBase()
        {
            IQueryable<TEntity> query = _dbSet;

            // if (filter != null && filter.Expressions != null)
            //     query = query.Where(filter.Expressions);

            // if (includes != null && includes.Expressions != null)
            //     query = includes.Expressions(query);

            // if (orderBy != null && orderBy.Expressions != null)
            //     query = orderBy.Expressions(query);

            return query;
        }

        public virtual void Create(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Deleted;
            _dbSet.Remove(entity);
        }

        public virtual int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}