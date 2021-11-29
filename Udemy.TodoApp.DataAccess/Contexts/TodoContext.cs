using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.DataAccess.Configurations;
using Udemy.TodoApp.Entities.Domains;

namespace Udemy.TodoApp.DataAccess.Contexts
{
    public class TodoContext:DbContext
    {
        public DbSet<Work> Works { get; set; }
        public TodoContext(DbContextOptions<TodoContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkConfiguration());
        }
    }
}
