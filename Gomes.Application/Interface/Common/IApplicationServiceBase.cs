using Gomes.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gomes.Application.Interface.Common
{
    public interface IApplicationServiceBase<TEntity> where TEntity : class 
    {
        void Add(TEntity obj);
        TEntity GetById(int? id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);

    }
}
