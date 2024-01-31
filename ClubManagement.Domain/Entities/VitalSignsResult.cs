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
    public class VitalSignsResult
    {
        [Key]
        public int Id { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? ModifyUserId { get; set; }

        public DateTime? ModifyDate { get; set; }


        [ForeignKey("CorrectiveAction")]
        public int CorrectiveActionId { get; set; }
        [ValidateNever]
        public CorrectiveAction CorrectiveAction { get; set; }

        [ForeignKey("VitalSign")]
        public int VitalSignsId { get; set; }
        [ValidateNever]
        public VitalSign VitalSign { get; set; }
    }
}
