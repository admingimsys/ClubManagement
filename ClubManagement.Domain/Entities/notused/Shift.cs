using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities.notused
{
    public class Shift
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الزامی")]
        public string Title { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الزامی")]
        public TimeOnly StartHour { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الزامی")]
        public TimeOnly EndHour { get; set; }
    }
}
