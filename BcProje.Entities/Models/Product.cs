using BcProje.Core.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BcProje.Entities.Models
{
    public class Product : IBaseEntity
    {
        [Key]
        public int ProductId { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }



        //Navigation Props

        public IEnumerable<CustomerProduct>? CustomerProducts { get; set; }

        public IEnumerable<SaleProduct>? SaleProducts { get; set; }
    }
}