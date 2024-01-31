using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ClubManagement.Domain.Entities
{
    public class Examination
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "الزامی")]
        [StringLength(50)]
        public string VisitNumber { get; set; }

        [StringLength(50)]
        public decimal? Height { get; set; }

        [StringLength(50)]
        public decimal? Weight { get; set; }

        [StringLength(100)]
        public string? RecoveryRate { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public int CreateUserId { get; set; }

        public DateOnly? Date { get; set; }

        public TimeOnly? Hour { get; set; }

        public string? MedicalRecordFile { get; set; }


        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        [ValidateNever]
        public Branch Branch { get; set; }

        [ForeignKey("BodyType")]
        public int? BodyTypeId { get; set; }
        [ValidateNever]
        public BodyType BodyType { get; set; }
        
        [ForeignKey("Referred")]
        public int ReferredId { get; set; }
        [ValidateNever]
        public Referred Referred { get; set; }

        [ForeignKey("User")]
        public int ExportId { get; set; }
        [ValidateNever]
        public User User { get; set; }

        [ForeignKey("Package")]
        public int PackageId { get; set; }
        [ValidateNever]
        public Package Package { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyUserId { get; set; }
    }
}
