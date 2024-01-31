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
    public class Anomalie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public string Titile { get; set; }

        [StringLength(50)]
        public string? LatinTitile { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(500)]
        public string Signs { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(500)]
        public string Reasons { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(500)]
        public string PreventionMethod { get; set; }

        public int CreateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime? ModifyDate { get; set; }


        [ForeignKey("AnomalieGroup")]
        public int AnomalieGroupId { get; set; }
        [ValidateNever]
        public AnomalieGroup AnomalieGroup { get; set; }

    }
}
