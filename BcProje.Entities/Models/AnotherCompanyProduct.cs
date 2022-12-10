using BcProje.Core.Abstract;
using System.ComponentModel.DataAnnotations;

namespace BcProje.Entities.Models
{
    public class AnotherCompanyProduct :IBaseEntity
    {
        [Key]
        public int AnotherProductId { get; set; }

        public string Name { get; set; }

        public decimal? Price { get; set; }


        //Navigation Props
        public virtual Customer? Customer { get; set; }
    }
}