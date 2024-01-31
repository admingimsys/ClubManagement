using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities.notused
{
    public class Device
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string? Code { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(250)]
        public string Feature { get; set; }


        [StringLength(250)]
        public string Considerations { get; set; }

    }
}
