using BcProje.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BcProje.WepAppUI.Controllers
{
    public class SaleController : Controller
    {
        private readonly ISaleService saleService;

        public SaleController(ISaleService saleService)
        {
            this.saleService = saleService;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
