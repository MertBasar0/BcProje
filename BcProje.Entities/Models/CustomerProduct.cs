
using BcProje.Core.Abstract;
using BcProje.Entities.Models;

namespace BcProje.Entities
{
    public class CustomerProduct : IBaseEntity
    {
        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }
    }
}