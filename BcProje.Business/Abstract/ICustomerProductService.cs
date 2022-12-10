using BcProje.Entities;
using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.Business.Abstract
{
    public interface ICustomerProductService
    {
        Task<bool> AddProductToCustomer(CustomerProduct cusPro);

        Task<List<Product>> GetAddedProduct(int customerId);

        Task<List<Product>> GetPossibleAddedProduct(int customerId);

        Task<bool> RemoveCustomerProduct(CustomerProduct cusPro);

    }
}
