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
    public class CurrectionalProgramDetail
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        public int SetCount { get; set; }

        [Required(ErrorMessage = "الزامی")]
        public int SetValue { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "الزامی")]
        public string Description { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? ModifyUserId { get; set; }

        public DateTime? ModifyDate { get; set; }


      
        public int CorrectiveActionId { get; set; }
        [ValidateNever]
        public CorrectiveAction CorrectiveAction { get; set; }

       
        public int CurrectionalProgramMasterId { get; set; }
        [ValidateNever]
        public CurrectionalProgramMaster CurrectionalProgramMaster { get; set; }

        
        public int ExaminationAnomalieId { get; set; }
        [ValidateNever]
        public ExaminationAnomalie ExaminationAnomalie { get; set; }

        public int UnitId { get; set;}
        [ValidateNever]
        public Unit Unit { get; set;}
    }
}
