using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.TodoApp.Common.ResponseObjects
{
    public class CustomValidationError
    {
        public string Message { get; set; }
        public string PropertyName { get; set; }
    }
}
