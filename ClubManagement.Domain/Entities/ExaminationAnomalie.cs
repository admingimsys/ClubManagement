using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities
{
    public class ExaminationAnomalie
    {
        [Key]
        public int Id { get; set; }

        //public double? Amount { get; set; }
        
        //[StringLength(500)]
        //public string? Discription { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? ModifyUserId { get; set; }

        public DateTime? ModifyDate { get; set; }

        //[ForeignKey("Unit")]
        //public int UnitId { get; set; }
        //[ValidateNever]
        //public Unit Unit { get; set; }

        [ForeignKey("Anomalie")]
        public int AnomalieId { get; set; }
        [ValidateNever]
        public Anomalie Anomalie { get; set; }

        [ForeignKey("Examination")]
        public int ExaminationId { get; set; }
        [ValidateNever]
        public Examination Examination { get; set; }
    }
}
