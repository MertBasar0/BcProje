using BcProje.Core.Conctrete;
using BcProje.DataAccess.Abstract;
using BcProje.Entities;
using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.DataAccess.Concrete
{
    public class SaleDal : GenericRepository<Sale, BcProjeDbContext>, ISaleDal
    {
    }
}
