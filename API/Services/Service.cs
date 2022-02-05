using System;
using System.Collections.Generic;
using System.Linq;
using API.Interfaces;

namespace API.Services
{
    public abstract class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        protected virtual IRepository<TEntity> repository { get; set; }

        public Service(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public IQueryable<TEntity> QueryDb() 
        {
            return repository.QueryDb();
        }


        public void Dispose()
        {
            repository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}