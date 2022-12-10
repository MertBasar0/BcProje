

using BcProje.Entities.Models;

namespace BcProje.Entities
{
    public class EmployeeCustomer
    {
        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public int EmployeeId { get; set; }

        public Employee? Employee { get; set; }
    }
}
