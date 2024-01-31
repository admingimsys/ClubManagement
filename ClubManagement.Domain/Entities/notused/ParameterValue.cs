using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities.notused
{
    public class ParameterValue
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public decimal Value { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? ModifyUserId { get; set; }

        public DateTime? ModifyDate { get; set; }

        [ForeignKey("Parameter")]
        public int ParameterId { get; set; }
        [ValidateNever]
        public Parameter Parameter { get; set; }


        [ForeignKey("Examination")]
        public int ExaminationId { get; set; }
        [ValidateNever]
        public Examination Examination { get; set; }
    }
}
