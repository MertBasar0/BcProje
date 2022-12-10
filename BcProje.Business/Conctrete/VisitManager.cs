using BcProje.Business.Abstract;
using BcProje.DataAccess.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.Business.Conctrete
{
    public class VisitManager : IVisitService
    {
        private readonly IVisitDal _visitDal;
        private readonly ICustomerDal _customerDal;
        public VisitManager(IVisitDal visitDal, ICustomerDal customerDal)
        {
            _visitDal = visitDal;
            _customerDal = customerDal;
        }

        public async Task ChangeToGone(int visitId)
        {
            var visit = await _visitDal.GetByIdAsync(visitId);
            if (visit is not null)
            {
                visit.State = VisitState.went;
                var updatedVisit = await _visitDal.UpdateAsync(visit);
            }
        }

        public async Task<bool> CreateVisit(Visit visit)
        {
            var result = await _visitDal.CreateAsync(visit);

            return result;
        }

        public async Task<string> GetCustomerNameById(int id)
        {
            var customer = await _customerDal.GetByIdAsync(id);

            return customer.Name;
        }

        public async Task<List<Customer>> GetCustomersForCreate()
        {
            return await _customerDal.GetAsync();
        }

        public async Task<List<Visit>> GetWaitingVisits(int _employeeId)
        {
            List<Visit> list = await _visitDal.GetAsync(x => x.EmployeeId == _employeeId && x.State == VisitState.waiting);

            return list;
        }

        public async Task<List<Visit>> GetWentOrCancelVisits(int employeeId)
        {
            List<Visit> list = await _visitDal.GetAsync(x => x.EmployeeId == employeeId && x.State == VisitState.went || x.State == VisitState.cancel);

            return list;
        }
    }
}
