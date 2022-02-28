using InfCommerce.DAL.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InfCommerce.BL.Repositories
{
    public class SqlRepo<T> : IRepo<T> where T : class
    {
        SqlContext db;
        public SqlRepo(SqlContext _db)
        {
            db = _db;
        }

        public void Add(T entity)
        {
            db.Set<T>().Add(entity);    
        }

        public void AddRange(IQueryable<T> entities)
        {
            db.Set<T>().AddRange(entities);   
        }

        public IQueryable<T> GetAll()
        {
            return db.Set<T>();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression);
        }

        public T GetBy()
        {
            return db.Set<T>().FirstOrDefault();
        }

        public T GetBy(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().FirstOrDefault(expression);
        }

        public void Remove(T entity)
        {
            db.Set<T>().Remove(entity);
        }

        public void RemoveRange(IQueryable<T> entities)
        {
            db.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
        }
    }
}
