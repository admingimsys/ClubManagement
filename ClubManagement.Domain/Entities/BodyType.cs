using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities
{
    public class BodyType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الزامی")]
        public string Title { get; set; }

        [StringLength(50)]
        public string? LatinTitle { get; set; }

        [StringLength(20)]
        public string? Code { get; set; }


    }
}
