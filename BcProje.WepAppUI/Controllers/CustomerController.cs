using BcProje.Business.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace BcProje.WepAppUI.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerManager;
        public CustomerController(ICustomerService customerManager)
        {
            _customerManager = customerManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var list = await _customerManager.GetAllCustomers();
            TempData["list"] = list;



            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateCustomer()
        {
            return PartialView("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customer Cus)
        {
            if (Cus is not null)
            {
                await _customerManager.CreateCustomer(Cus);
                return RedirectToAction("Index", Cus);
            }
            
            return View("Index");
        }

        
    }
}
