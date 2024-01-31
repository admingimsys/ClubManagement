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
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string? Description { get; set; }

        public int Time { get; set; }

        [StringLength(150)]
        public string? Conditions { get; set; }

        public bool? IsActive { get; set; }


        [ForeignKey("ServicesGroup")]
        public int ServicesGroupId { get; set; }
        [ValidateNever]
        public ServicesGroup ServicesGroup { get; set; }
    }
}
