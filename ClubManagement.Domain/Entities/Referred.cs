using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubManagement.Domain.Entities;

public class Referred
{
    [Key]
    public int Id { get; set; }

	[StringLength(50)]
	[Required(ErrorMessage = "الزامی")]
	public string? Name { get; set; }

	[StringLength(50)]
	[Required(ErrorMessage = "الزامی")]
	public string? Family { get; set; }

	[StringLength(20)]
	public string? Code { get; set; }

    [ValidateNever]
    [Required(ErrorMessage = "الزامی")]
    public DateOnly? BirthDate { get; set; }

    [ValidateNever]
    [Required(ErrorMessage = "الزامی")]
	public bool? Gender { get; set; }

	[StringLength(20)]
	[Required(ErrorMessage = "الزامی")]
	public string? Mobile { get; set; }

	[StringLength(20)]
	public string? Phone { get; set; }

	[StringLength(400)]
	public string? Description { get; set; }

	[StringLength(20)]
	[Required(ErrorMessage = "الزامی")]
	public string? NationalCode { get; set; }

	[StringLength(30)]
	[Required(ErrorMessage = "الزامی")]
	public string? PassWord { get; set; }

	[StringLength(30)]
	[Required(ErrorMessage = "الزامی")]
	public string? UserName { get; set; }

    public bool? IsMarid { get; set; }

	[StringLength(30)]
    public string? Job { get; set; }

	public byte[]? Image { get;set; }

    public int CreateUserId { get; set; }

	public DateTime CreateDate { get; set; }

	public int? ModifyUserId { get; set; }

	public DateTime? ModifyDate { get; set; }


	[ForeignKey("State")]
	public int StateId { get; set; }
	[ValidateNever]
	public State State { get; set; }

	[ForeignKey("IntroductionMethod")]
	public int IntroductionMethodId { get; set; }
    [ValidateNever]
    public IntroductionMethod IntroductionMethod { get; set; }
}
