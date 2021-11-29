using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Udemy.TodoApp.Entities.Domains;

namespace Udemy.TodoApp.DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetByFilter(Expression<Func<T, bool>> filter,bool AsNoTracking=false);
        Task<T> Find(int id);
        Task Create(T entity);
        void Update(T unchanged, T entity);
        void Remove(T entity);
        IQueryable<T> GetQueryable();

    }
}
