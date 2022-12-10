using BcProje.Core.Abstract;
using BcProje.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace BcProje.Entities.Models
{
    public class Sale : IBaseEntity
    {
        [Key]
        public int SaleId { get; set; }

        public DateTime Date { get;} = DateTime.Now;

        public decimal SaleCount { get; set; }


        //Navigation Props

        public virtual Visit Visit { get; set; }

        public IEnumerable<SaleProduct>? SaleProducts { get; set; }

        //public decimal SoldPrice()
        //{
        //    Visit.Sale.SoldProducts.Select(x=>x.Product.Price);
        //    return null;
        //}

        //CompositeKey tablolarını Visit ile güncelle
    }
}