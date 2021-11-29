using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.DataAccess.Contexts;
using Udemy.TodoApp.DataAccess.Interfaces;
using Udemy.TodoApp.Entities.Domains;

namespace Udemy.TodoApp.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T :BaseEntity
    {
        private readonly TodoContext _context;
        public Repository(TodoContext context)
        {
            _context = context;
        }
        public async Task Create(T entity)
        {
          await _context.Set<T>().AddAsync(entity);
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByFilter(Expression<Func<T, bool>> filter, bool AsNoTracking = false)
        {
            if (AsNoTracking)
            {
                return await _context.Set<T>().SingleOrDefaultAsync(filter);
            }
            else
            {
                return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
            }
        }

        public async Task<T> Find(int id)
        {
            return await _context.Set<T>().SingleOrDefaultAsync(x=>x.Id==id);
        }

        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        //Takes Unchanged entity and changed entity with values
        public void Update(T unchanged,T entity)
        {
          _context.Entry(unchanged).CurrentValues.SetValues(entity);
        }
    }
}
