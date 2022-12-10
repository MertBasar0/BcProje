using BcProje.Business.Abstract;
using BcProje.DataAccess.Abstract;
using BcProje.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProje.Business.Conctrete
{
    public class SaleManager : ISaleService
    {
        private readonly ISaleDal _saleDal;

        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }



        public async Task<bool> CreateSale(Sale sale)
        {
            var result = await _saleDal.CreateAsync(sale);

            return result;
        }
    }
}
