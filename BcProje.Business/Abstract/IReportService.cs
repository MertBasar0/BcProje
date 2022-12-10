using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.Business.Abstract
{
    public interface IReportService 
    {
        Task<bool> CreateReport(Report report);

        Task<List<Report>> GetReportListByVisitId(int id);
    }
}
