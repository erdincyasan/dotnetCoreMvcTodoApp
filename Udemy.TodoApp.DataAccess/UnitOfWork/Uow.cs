using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.DataAccess.Contexts;
using Udemy.TodoApp.DataAccess.Interfaces;
using Udemy.TodoApp.DataAccess.Repositories;
using Udemy.TodoApp.Entities.Domains;

namespace Udemy.TodoApp.DataAccess.UnitOfWork
{
    public class Uow:IUow
    {
        private readonly TodoContext _context;
        public Uow(TodoContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task<bool> SaveChanges()
        {
          return  await _context.SaveChangesAsync()>=0;
        }
    }
}
