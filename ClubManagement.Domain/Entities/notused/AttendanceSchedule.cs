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
    public class AttendanceSchedule
    {
        [Key]
        public int Id { get; set; }

        [ValidateNever]
        [Required(ErrorMessage = "الزامی")]
        public DateOnly Date { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        [ValidateNever]
        public User User { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        [ValidateNever]
        public Branch Branch { get; set; }

        [ForeignKey("Shift")]
        public int ShiftId { get; set; }
        [ValidateNever]
        public Shift Shift { get; set; }

        [ForeignKey("UserType")]
        public int? UserTypeId { get; set; }
        [ValidateNever]
        public UserType UserType { get; set; }
    }
}
