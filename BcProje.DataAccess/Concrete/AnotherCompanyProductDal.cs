using BcProje.Core.Conctrete;
using BcProje.DataAccess.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;

namespace BcProje.DataAccess.Concrete
{
    public class AnotherCompanyProductDal : GenericRepository<AnotherCompanyProduct,BcProjeDbContext>, IAnotherCompanyProductDal
    {
    }
}
    