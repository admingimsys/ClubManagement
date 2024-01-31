using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubManagement.Domain.Entities;

public class SpecialDisease
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
	[Required(ErrorMessage = "الزامی")]
	public string Title { get; set; }

	[StringLength(50)]
	public string? LatinTitile { get; set; }
}
