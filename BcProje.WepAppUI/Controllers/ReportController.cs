using BcProje.Business.Abstract;
using BcProje.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace BcProje.WepAppUI.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;
        private readonly IVisitService _visitService;

        public ReportController(IReportService reportService, IVisitService visitService)
        {
            _reportService = reportService;
            _visitService = visitService;
        }

        [HttpGet]
        public IActionResult Index()
        { 
            var visitId = Request.Query["visitId"];

            ViewBag.visitId = visitId;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateReport(Report report)
        {
            //Create ve Index sayfalarını birbirinden ayır.

            var result = await _reportService.CreateReport(report);

            await _visitService.ChangeToGone(Convert.ToInt32(report.VisitId));

            if (report._Result == Result.TrialGiven)
            {
                var query = HttpContext.Features;
                return Redirect("http://localhost:17266/Visit");
            }
            else
            {
                return Redirect("http://localhost:17266/Sale");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetReportListByVisitId()
        {
            var visitId = Request.Query["visitId"];

            var list = await _reportService.GetReportListByVisitId(Convert.ToInt32(visitId));

            ViewBag.visitId = Convert.ToInt32(visitId);

            return View(list);
        }

    }
}
