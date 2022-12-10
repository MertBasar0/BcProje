using BcProje.Business.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace BcProje.WepAppUI.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.list = await _employeeService.GetEmployees();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateEmployee()
        {

            return PartialView("_CreateEmployees");
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(Employee emp)
        {
            if (emp is not null)
            {
                bool result = await _employeeService.AddEmployeeAsync(emp);
                return RedirectToAction("Index");
            }

            return Redirect("Index");
           
        }

    }
}
