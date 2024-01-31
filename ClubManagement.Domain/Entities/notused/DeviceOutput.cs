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
    public class DeviceOutput
    {
        [Key]
        public int Id { get; set; }

        public byte[] OutputFile { get; set; }

        public int CreateUserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int? ModifyUserId { get; set; }

        public DateTime? ModifyDate { get; set; }


        [ForeignKey("Device")]
        public int DeviceId { get; set; }
        [ValidateNever]
        public Device Device { get; set; }

        [ForeignKey("Examination")]
        public int ExaminationId { get; set; }
        [ValidateNever]
        public Examination Examination { get; set; }
    }
}
