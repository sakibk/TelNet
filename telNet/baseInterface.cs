using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace telNet
{
    public interface baseInterface<T>
    {
        telNetContext baseContext();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T oldEntity, T newEntity);
        T get(int Id);
        IQueryable<T> Get();
        void Commit();
    }
}