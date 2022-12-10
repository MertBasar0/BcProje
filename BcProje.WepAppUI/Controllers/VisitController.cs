using BcProje.Business.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace BcProje.WepAppUI.Controllers
{
    public class VisitController : Controller
    {
        private readonly IVisitService _visitService;

        public VisitController(IVisitService visitService)
        {
            _visitService = visitService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _visitService.GetWaitingVisits(1);

            //EagerLoading'in uygulanışını not al. Lazy Loading vs EagerLoading daha derin araştır. Makalesini yaz.

            return View(result);
        }


        [HttpGet]
        public async Task<IActionResult> CreateVisit()
        {
            TempData["customers"] = await _visitService.GetCustomersForCreate();

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateVisit(Visit visit)
        {
            //Burada Visit ComplexType'ı için navigation proplara ek olarak bu proplara post işlemi için birer de foreignKey ekledik.
            //Çünkü post işlemlerinde direk navi. proplar üzerinden post işlemi yapılamıyor.

            var result =  await _visitService.CreateVisit(visit);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> WentOrCancelVisits()
        {
           var list = await _visitService.GetWentOrCancelVisits(1);

            return View(list);

            //Burada kaldın. Bu sayfada ok'a basıldığında raporları getirecek view'i yaz.
        }


    }
}
