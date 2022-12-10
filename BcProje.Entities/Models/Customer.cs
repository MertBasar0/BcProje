using BcProje.Core.Abstract;
using BcProje.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace BcProje.Entities.Models
{
    public class Customer : IBaseEntity
    {
        [Key]
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public int? UnitCount { get; set; }

        public string? SaleManager { get; set; }

        public string? GeneralManager { get; set; }

        public string Region { get; set; }

        public string? Address { get; set; }

        public string? ComNo { get; set; }

        public string? Mail { get; set; }

        public string? DoctorName { get; set; }



        //Navigation Props

        public virtual IEnumerable<Visit>? Visits { get; set; }

        public IEnumerable<CustomerProduct>? CustomerProducts { get; set; }

        public virtual IList<AnotherCompanyProduct>? AnotherCompanyProducts { get; set; }

        public IEnumerable<EmployeeCustomer>? EmployeeCustomers{ get; set; }
    }
}