using BcProje.Entities;
using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.Business.Abstract
{
    public interface ICustomerService
    {
        Task<bool> CreateCustomer(Customer customer);

        Task<List<Customer>> GetAllCustomers();

        Task<Customer> GetCustomerById(int id);
    }
}
