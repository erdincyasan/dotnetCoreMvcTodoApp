using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Common.Enums;

namespace Udemy.TodoApp.Common.ResponseObjects
{
    public class Response:IResponse
    {
        public string Message { get; set; }
        public ResponseType ResponseType { get; set; }
        public Response(ResponseType responseType)
        {
            ResponseType = responseType;
        }
        public Response(ResponseType responseType,string message)//:this(responseType)
        {
            Message = Message;
            ResponseType = responseType;
        }

    }
}
