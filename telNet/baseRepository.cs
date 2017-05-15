using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace telNet
{
    public class baseRepository<T> : baseInterface<T> where T : class
    {
        protected telNetContext ctx;
        protected DbSet<T> dbset;

        public baseRepository(telNetContext dCon)
        {
            ctx = dCon;
            dbset = ctx.Set<T>();
        }

        public telNetContext baseContext()
        {
            return ctx;
        }

        public T get(int Id)
        {
            return dbset.Find(Id);
        }

        public IQueryable<T> Get()
        {
            return dbset;
        }

        public void Insert(T entity)
        {
            dbset.Add(entity);
        }

        public void Update(T oldEntity, T newEntity)
        {
            ctx.Entry(oldEntity).CurrentValues.SetValues(newEntity);
        }

        public void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public void Commit()
        {
            ctx.SaveChanges();
        }

    }
}