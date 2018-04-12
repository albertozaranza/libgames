using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Repositories
{
    public class RepositoryBase<T> where T : class
    {
        private readonly StoreContext _context;

        public RepositoryBase(StoreContext context)
        {
            this._context = context;
        }

        public virtual T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public virtual void Update(T entity, int id)
        {
            var exist = _context.Set<T>().Find(id);
            _context.Entry(exist).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}
