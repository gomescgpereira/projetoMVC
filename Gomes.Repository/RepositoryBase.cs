using Gomes.Domain.Entity;
using Gomes.Domain.Interfaces.Repository.Common;
using Gomes.Repository.Fake;
using System;
using System.Collections.Generic;

namespace Gomes.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        public DadosFake db = new DadosFake();

        public void Add(TEntity obj)
        {
            db.Add();
            db.Save();

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            return db.Get();
        }

        public TEntity GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepositoryBase<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
