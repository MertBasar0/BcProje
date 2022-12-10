using BcProje.Core.Abstract;
using BcProje.Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace BcProje.Entities.Models
{
    public class Employee : IBaseEntity
    {
        [Key]
        public int EmployeeId { get; set; }

        public string Name { get; set; }


        //Navigation Props

        public virtual IEnumerable<Visit>? Visits { get; set; }

        public IEnumerable<EmployeeCustomer>? EmployeeCustomers { get; set; }
    }
}
