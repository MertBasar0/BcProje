using BcProje.DataAccess.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;

namespace BcProje.Business.Abstract
{
    public interface IEmployeeService
    {
        Task<bool> AddEmployeeAsync(Employee emp);

        Task<List<Employee>> GetEmployeesByNameAsync(string word);

        Task<List<Employee>> GetEmployees();
    }
}
