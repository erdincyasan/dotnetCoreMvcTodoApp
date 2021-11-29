using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Business.Interfaces;
using Udemy.TodoApp.Business.Mappings.AutoMapper;
using Udemy.TodoApp.Business.Services;
using Udemy.TodoApp.Business.Validators;
using Udemy.TodoApp.DataAccess.Contexts;
using Udemy.TodoApp.DataAccess.UnitOfWork;
using Udemy.TodoApp.Dtos.WorkDtos;

namespace Udemy.TodoApp.Business.Extensions
{
    public static class ServicesExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            //Setting DB
            services.AddDbContext<TodoContext>(options =>
            {
                options.UseSqlServer("Server=localhost;Database=TodoAppDB;Integrated Security=true");
                options.LogTo(Console.WriteLine,Microsoft.Extensions.Logging.LogLevel.Information);
            });
            //Automapper settings
            var configuration = new MapperConfiguration(opt =>
              {
                  opt.AddProfile(new WorkProfile());
              });
            var mapper = configuration.CreateMapper();
            services.AddSingleton(mapper);

            //Fluent Validation DI
            services.AddTransient<IValidator<WorkUpdateDto>, WorkUpdateValidator>();
            services.AddTransient<IValidator<WorkCreateDto>, WorkCreateValidator>();
            //Adding Unit of work on DI
            services.AddScoped<IUow, Uow>();

            //Adding Services on DI
            services.AddScoped<IWorkService, WorkService>();

        }
    }
}
