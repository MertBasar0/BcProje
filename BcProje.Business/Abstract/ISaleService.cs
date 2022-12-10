using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.Business.Abstract
{
    public interface ISaleService
    {
        Task<bool> CreateSale(Sale sale);
    }
}
