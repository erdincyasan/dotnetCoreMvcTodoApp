using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Common.Enums;

namespace Udemy.TodoApp.Common.ResponseObjects
{
    public interface IResponse
    {
         string Message { get; set; }
         ResponseType ResponseType { get; set; }
    }
}
