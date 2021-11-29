using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.TodoApp.Business.Interfaces;
using Udemy.TodoApp.Common.Enums;
using Udemy.TodoApp.Dtos.WorkDtos;
using Udemy.TodoApp.UI.Extensions;

namespace Udemy.TodoApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkService _workService;
        public HomeController(IWorkService workService)
        {
            _workService = workService;
        }
        public async Task<IActionResult> Index()
        {
            var response = await _workService.GetAll();

            if (response.ResponseType==ResponseType.NotFound)
            {
                return RedirectToAction("Create");
            }
            return View(response.Data);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View(new WorkCreateDto());
        }
        [HttpPost]
        public async Task<IActionResult> Create(WorkCreateDto workCreateDto)
        {
            var response = await _workService.Create(workCreateDto);//Returning Response
            return this.ResponseRedirectToAction(response, "Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var response = await _workService.GetById<WorkUpdateDto>(id);
            return this.ResponseView(response);
        }
        [HttpPost]
        public async Task<IActionResult> Update(WorkUpdateDto workUpdateDto)
        {

            var response=await _workService.Update(workUpdateDto);
            return this.ResponseRedirectToAction(response, "Index");

        }
        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
           var response= await _workService.Remove(id);
           return this.ResponseRedirectToAction(response,"Index");
        }
        public  IActionResult NotFound(int code)
        {
            return View();
        }
    }
}
