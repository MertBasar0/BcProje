using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.Business.Abstract
{
    public interface IVisitService
    {
        Task<List<Visit>> GetWaitingVisits(int employeeId);

        Task<List<Visit>> GetWentOrCancelVisits(int employeeId);

        Task<List<Customer>> GetCustomersForCreate();

        Task<bool> CreateVisit(Visit visit);

        Task<string> GetCustomerNameById(int id);

        Task ChangeToGone(int visitId);
    }
}
