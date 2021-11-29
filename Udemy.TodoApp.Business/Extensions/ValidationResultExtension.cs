using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Common.ResponseObjects;

namespace Udemy.TodoApp.Business.Extensions
{
    public static class ValidationResultExtension
    {
        public static List<CustomValidationError> ConvertToCustomValidationError(this ValidationResult validationResult)
        {
            var errors = new List<CustomValidationError>();
            foreach (var item in validationResult.Errors)
            {
                errors.Add(new CustomValidationError
                {
                    Message = item.ErrorMessage,
                    PropertyName = item.PropertyName,
                });
            }
            return errors;
        }
    }
}
