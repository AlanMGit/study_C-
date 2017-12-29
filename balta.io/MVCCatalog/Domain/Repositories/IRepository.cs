using System;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IRepository<T> : IDisposable
    {

        IList<T> Get();
        T Get(int id);
        void Save(T entity);
        void Update(int id, T entity);
        void Delete(int id);

    }
}
