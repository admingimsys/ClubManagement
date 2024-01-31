using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الزامی")]
        public string Title { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الزامی")]
        public string LatinTitle { get; set; }

        [ValidateNever]
        public bool? IsFood { get; set; }

        [ValidateNever]
        public bool? IsAnomali { get; set; }

        [ValidateNever]
        public bool? IsAction { get; set; }

        [ValidateNever]
        public bool? IsVitalSing { get; set; }
    }
}
