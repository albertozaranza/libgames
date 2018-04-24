using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {   
        T GetById(int id);

        IQueryable<T> GetAll();

        T Create(T entity);

        void Delete(int id);

        void Update(T entity, int id);
    }
}
