using BcProje.Core.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum VisitState
{
    waiting, went, cancel
}
namespace BcProje.Entities.Models
{
    public class Visit : IBaseEntity
    {
        [Key]
        public int VisitId { get; set; }

        public DateTime Date { get; set; }

        public VisitState State { get; set; } = VisitState.waiting;

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }


        //Navigation Props
        
        public virtual IEnumerable<Sale>? Sale { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual IEnumerable<Report>? Reports { get; set; }


    }
}
