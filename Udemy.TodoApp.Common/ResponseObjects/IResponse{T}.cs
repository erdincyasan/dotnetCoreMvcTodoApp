using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Common.Enums;

namespace Udemy.TodoApp.Common.ResponseObjects
{
    public interface IResponse<T>
    {
        T Data { get; set; }
        ResponseType ResponseType { get; set; }
        List<CustomValidationError> ValidationErrors { get; set; }
    }
}
