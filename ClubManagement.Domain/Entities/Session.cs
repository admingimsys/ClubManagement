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
    public class Session
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public string Title { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public string LatinTitle { get; set; }


        [ForeignKey("SessionGroup")]
        public int SessionGroupId { get; set; }
        [ValidateNever]
        public SessionGroup SessionGroup { get; set; }
    }
}
