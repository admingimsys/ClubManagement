using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubManagement.Domain.Entities;

public class HealthInfo
{
    [Key]
    public int Id { get; set; }

    public byte[]? MedicalRecordFormFile {  set; get; }

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    [StringLength(200)]
    public string? DiseaseBackgrand { get; set; }

	[Required(ErrorMessage = "الزامی")]
	public bool? HadSurgery { get; set; }

	[StringLength(200)]
	public string? DrugUsed { get; set; }

	[Required(ErrorMessage = "الزامی")]
	public bool? HasMetallInBody { get; set; }

    public bool? HasPreviousDiet { get; set; }

    public decimal? HighestWeight { get; set; }

    public decimal? LowestWeight { get; set; }

	[StringLength(100)]
	public string? SleepingTime { get; set; }

	[StringLength(100)]
	[Required(ErrorMessage = "الزامی")]
	public string? Appetite { get; set; }

	[StringLength(100)]
	public string? physicalActivityAmount { get;set; }

	public int CreateUserId { get; set; }

	public DateTime CreateDate { get; set; }

	public int? ModifyUserId { get; set; }

	public DateTime? ModifyDate { get; set; }


	[ForeignKey("Referred")]
	public int ReferredId { get; set; }
	public Referred Referred { get; set; }
}
