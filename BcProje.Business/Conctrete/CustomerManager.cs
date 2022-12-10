using BcProje.Business.Abstract;
using BcProje.DataAccess.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;

namespace BcProje.Business.Conctrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public async Task<bool> CreateCustomer(Customer customer)
        {
            if (customer is not null)
            {
                var result = await _customerDal.CreateAsync(customer);
                return result;
            }

            return false;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _customerDal.GetAsync();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            Customer cust = await _customerDal.GetByIdAsync(id);

            return cust;

        }
    }
}
