using BcProje.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum Result
{
    Sold, NotSold, TrialGiven
}

namespace BcProje.Entities.Models
{

    public class Report : IBaseEntity
    {
        [Key]
        public int ReportId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public string? VisitNote { get; set; }

        public Result _Result { get; set; } = Result.NotSold;

        [ForeignKey("VisitId")]
        public int VisitId { get; set; }



        //Navigation Props

        public virtual Visit? Visit { get; set; }




    }
}
