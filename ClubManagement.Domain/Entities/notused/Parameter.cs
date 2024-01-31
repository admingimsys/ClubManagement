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
    public class Parameter
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(70)]
        public string Title { get; set; }

        [StringLength(70)]
        public decimal? MaxBalance { get; set; }

        [StringLength(70)]
        public decimal? MinBalance { get; set; }


        [ForeignKey("Unit")]
        public int UnitId { get; set; }
        [ValidateNever]
        public Unit Unit { get; set; }

        [ForeignKey("Device")]
        public int DeviceId { get; set; }
        [ValidateNever]
        public Device Device { get; set; }
    }
}
