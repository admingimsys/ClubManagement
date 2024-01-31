using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الزامی")]
        public string Name { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "الزامی")]
        public string Code { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "الزامی")]
        public string Address { get; set; }

        [StringLength(20)]
        public string? Phone { get; set; }
    }
}
