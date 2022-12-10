using BcProje.Business.Abstract;
using BcProje.DataAccess.Abstract;
using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.Business.Conctrete
{
    public class ReportManager : IReportService
    {
        private readonly IReportDal _reportDal;

        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }


        public async Task<bool> CreateReport(Report report)
        {
            var result = await _reportDal.CreateAsync(report);

            return result;
        }

        public async Task<List<Report>> GetReportListByVisitId(int id)
        {
            List<Report> result = await _reportDal.GetAsync(x => x.VisitId == id);

            return result;
        }
    }
}
