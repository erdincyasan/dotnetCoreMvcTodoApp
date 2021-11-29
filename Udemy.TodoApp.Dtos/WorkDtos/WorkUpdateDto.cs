using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoApp.Dtos.Interfaces;

namespace Udemy.TodoApp.Dtos.WorkDtos
{
    public class WorkUpdateDto : IDto
    {
        //[Range(1,int.MaxValue)]
        public int Id { get; set; }
        //[Required(ErrorMessage ="İş Tanımı kısmı gereklidir")]
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
