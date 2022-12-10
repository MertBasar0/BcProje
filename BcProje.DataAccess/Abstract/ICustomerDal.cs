using BcProje.Core.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.DataAccess.Abstract
{
    public interface ICustomerDal : IGenericRepository<Customer>
    {
    }
}
