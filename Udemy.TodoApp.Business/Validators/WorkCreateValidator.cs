using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Dtos.WorkDtos;

namespace Udemy.TodoApp.Business.Validators
{
    public class WorkCreateValidator:AbstractValidator<WorkCreateDto>
    {
        public WorkCreateValidator()
        {
            RuleFor(x => x.Definition).NotEmpty().WithMessage("İş tanımı kısmı gereklidir");
        }
    }
}
