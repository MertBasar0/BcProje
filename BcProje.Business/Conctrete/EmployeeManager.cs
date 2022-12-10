using BcProje.Business.Abstract;
using BcProje.DataAccess.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;

namespace BcProje.Business.Conctrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }


        public async Task<bool> AddEmployeeAsync(Employee emp)
        {
            var result = await _employeeDal.CreateAsync(emp);
            return result;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var list = await _employeeDal.GetAsync();
            return list;
        }

        public async Task<List<Employee>> GetEmployeesByNameAsync(string word = null)
        {
            List<Employee> List;
            if (word is not null)
            {
                List = await _employeeDal.GetAsync(x => x.Name.StartsWith(word) || x.Name.EndsWith(word));
            }
            List = await _employeeDal.GetAsync();

            return List;
        }
    }
}
