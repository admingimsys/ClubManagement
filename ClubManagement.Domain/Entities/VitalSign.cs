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
    public class VitalSign
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public string LatinName { get; set; }

        public int CreateUserId { get; set; }

        public DateTime RegisterDate { get; set; }

        public int? ModifyUserId { get; set; }

        public DateTime? ModifyDate { get; set; }

        [ForeignKey("Unit")]
        public int UnitId { get; set; }
        [ValidateNever]
        public Unit Unit { get; set; }
    }
}
