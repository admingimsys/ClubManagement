using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Domain.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الزامی")]
        public string Name { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "الزامی")]
        public string Family { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "الزامی")]
        public string NationalCode { get; set; }

        [StringLength(20)]
        public string? Phone { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "الزامی")]
        public string Mobile { get; set; }

        [ValidateNever]
        [Required(ErrorMessage = "الزامی")]
        public bool Gender { get; set; }

        [ValidateNever]
        [Required(ErrorMessage = "الزامی")]
        public DateOnly BirthDate { get; set; }

        [StringLength(50)]
        public string? MedicalSystemNumber { get; set; }

        [StringLength(50)]
        public string? Evidence { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "الزامی")]
        public string UserName { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "الزامی")]
        public string PassWord { get; set; }

        [NotMapped]
        [StringLength(30)]
        [Required(ErrorMessage = "الزامی")]
        [Compare("Password", ErrorMessage = "رمز عبور با تکرار آن همخوانی ندارد!")]
        [ValidateNever]
        public string ConfirmPassWord { get; set; }

        [ValidateNever]
        [Required(ErrorMessage = "الزامی")]
        public bool IsActive { get; set; }

        [StringLength(30)]
        public string? BioLink { get; set; }

        public byte[]? Image { get; set; }

        public string? RezumeFile { get; set; }

        [ForeignKey("UserType")]
        public int UserTypeId { get; set; }
        [ValidateNever]
        public UserType UserType { get; set; }
    }
}
