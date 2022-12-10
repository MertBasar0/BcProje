using BcProje.Core.Conctrete;
using BcProje.DataAccess.Abstract;
using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.DataAccess.Concrete
{
    public class VisitDal : GenericRepository<Visit,BcProjeDbContext>, IVisitDal
    {
    }
}
