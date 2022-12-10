using BcProje.Core.Conctrete;
using BcProje.DataAccess.Abstract;
using BcProje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.DataAccess.Concrete
{
    public class CustomerProductDal : GenericRepository<CustomerProduct,BcProjeDbContext>, ICustomerProductDal
    {

        public async Task<bool> RemoveDataFormInstance(CustomerProduct cusPro)
        {
            using var context = new BcProjeDbContext();
            await Task.Run(() =>  context.Remove(cusPro));
            var result = await context.SaveChangesAsync();

            return Convert.ToBoolean(result);
        }
    }
}
