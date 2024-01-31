using Microsoft.AspNetCore.Http;
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
    public class CorrectiveAction
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        public byte[]? Image { get; set; }

        public string? VideoUrl { get; set; }

        public int CreateUserId { get; set; }
        public DateTime CreatDate { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime? ModifyDate { get; set; }


        [ForeignKey("CorrectiveActionGroup")]
        public int CorrectiveActionGroupId { get; set; }
        [ValidateNever]
        public CorrectiveActionGroup CorrectiveActionGroup { get; set; }

        //[ForeignKey("Unit")]
        //public int UnitId { get; set; }
        //[ValidateNever]
        //public Unit Unit { get; set; }
    }
}
