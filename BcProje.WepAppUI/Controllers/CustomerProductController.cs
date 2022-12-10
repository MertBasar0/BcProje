using BcProje.Business.Abstract;
using BcProje.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BcProje.WepAppUI.Controllers
{
    public class CustomerProductController : Controller
    {

        private readonly ICustomerProductService _customerProductService;

        public CustomerProductController(ICustomerProductService customerProductService)
        {
            _customerProductService = customerProductService;

        }

        public async Task<IActionResult> Index(int customerId)
        {
            var addedList = await _customerProductService.GetAddedProduct(customerId);
            if (addedList is not null)
                ViewData["Added"] = addedList;
            var possibleList = await _customerProductService.GetPossibleAddedProduct(customerId);
            if (possibleList is not null)
                ViewData["Possible"] = possibleList;

            TempData["customerId"] = customerId;
            TempData.Keep("customerId");

            //CustomerId neden 0 dönüyor bunu araştır. ==> Bunun sebebi name ve value değerinin gönderildiği butonun form tagının içine alınmaması.


            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(CustomerProduct cusPro)
        {
            await _customerProductService.AddProductToCustomer(cusPro);
            return RedirectPreserveMethod("Index");
        }

        //Burada add fonksiyonunda kullanılacak değişkenlerden musteriId nin action a nasıl taşınacağı konusunda bir çözüm bulunmalı.

        [HttpPost]
        public async Task<IActionResult> RemoveCustomerProduct(CustomerProduct cusPro)
        {
            await _customerProductService.RemoveCustomerProduct(cusPro);

            return RedirectPreserveMethod("Index");
        }
    }
}
