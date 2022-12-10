using BcProje.Business.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace BcProje.WepAppUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.list = await _productService.GetAllProducts();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            await _productService.AddProduct(product);
            return Redirect("Index");
        }



    }
}
