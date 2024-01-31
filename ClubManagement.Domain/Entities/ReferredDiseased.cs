using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubManagement.Domain.Entities;

public class ReferredDiseased
{
	[Key]
	public int Id { get; set; }

	public int? CreatedUserId { get; set; }

	public int? ModifyUserId { get; set; }
	
	public DateTime? CreateDate { get; set; }

	public DateTime? ModifyDate { get; set; }


	[ForeignKey("SpecialDisease")]
	public int SpecialDiseaseId { get; set; }
	[ValidateNever]
	public SpecialDisease SpecialDisease { get; set; }

	[ForeignKey("Referred")]
	public int ReferredId { get; set; }
	[ValidateNever]
	public Referred Referred { get; set; }
}
