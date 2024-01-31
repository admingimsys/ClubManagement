using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities
{
    public class CorrectiveActionGroup
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string LatinTitle { get; set; }

        [StringLength(50)]
        public string? Code { get; set; }
    }
}
