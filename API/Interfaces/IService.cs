using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Interfaces
{
    public interface IService<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        IQueryable<TEntity> QueryDb();
    }
}