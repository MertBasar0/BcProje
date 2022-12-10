using BcProje.Core.Abstract;
using BcProje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.DataAccess.Abstract
{
    public interface ICustomerProductDal : IGenericRepository<CustomerProduct>
    {
        Task<bool> RemoveDataFormInstance(CustomerProduct cusPro);

    }
}
