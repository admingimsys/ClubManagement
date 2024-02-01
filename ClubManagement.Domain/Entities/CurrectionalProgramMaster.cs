using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities
{
    public class CurrectionalProgramMaster
    {

        [Key]
        public int Id { get; set; }

        public string Code { get; set; }

        public DateOnly? Date { get; set; }

        public TimeOnly? EntranceHour { get; set; }

        public TimeOnly? LeavingHour { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? ModifyUserId { get; set; }

        public DateTime? ModifyDate { get; set; }

        [ForeignKey("Session")]
        public int SessionId { get; set; }
        [ValidateNever]
        public Session Session { get; set; }


        [ForeignKey("Examination")]
        public int ExaminationId { get; set; }
        [ValidateNever]
        public Examination Examination { get; set; }

        [ForeignKey("Branch")]
        public int? BranchId { get; set; }
        [ValidateNever]
        public Branch Branch { get; set; }
    }
}
