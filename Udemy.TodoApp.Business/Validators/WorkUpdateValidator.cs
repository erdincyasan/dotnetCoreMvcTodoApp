using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Dtos.WorkDtos;

namespace Udemy.TodoApp.Business.Validators
{
    public class WorkUpdateValidator:AbstractValidator<WorkUpdateDto>
    {
        public WorkUpdateValidator()
        {
            RuleFor(x=>x.Id).NotEmpty();
            RuleFor(x=>x.Id).GreaterThan(0);
            RuleFor(x=>x.Definition).NotEmpty().WithMessage("İş tanımı kısmı boş olamaz");
        }
    }
}
