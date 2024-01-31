using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubManagement.Domain.Entities;

public class PersonalInfo
{
    [Key]
    public int Id { get; set; }

	[StringLength(400)]
	[Required(ErrorMessage = "الزامی")]
	public string Address { get; set; }

	[StringLength(30)]
	public string? PostalCode { get; set; }

	[StringLength(20)]
	[Required(ErrorMessage = "الزامی")]
	public string EssentialPhone { get; set; }

	[StringLength(50)]
	public string? Email { get; set; }

	public int CreateUserId { get; set; }

	public DateTime CreateDate { get; set; }

	public int? ModifyUserId { get; set; }

	public DateTime? ModifyDate { get; set; }


	[ForeignKey("Referred")]
    public int ReferredId { get; set; }
    public Referred Referred { get; set; }
}
