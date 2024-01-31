using ClubManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClubManagement.Web.ViewModels
{
	public class ReferredVM
	{
		public string gender { get; set; }
		public string isMaried { get; set; }
		public Referred referred { get; set; }
        public string birthDate { get; set; }
        public IFormFile? ImageFile { get; set; }
        public List<IntroductionMethod>? IntroductionMethods { get; set; }
        public List<State>? States { get; set; }


        //public string hasSurgery { get; set; }
        //public PersonalInfo personalInfo { get; set; }
        //public HealthInfo healthInfo { get; set; }
        //public List<int> specialDiseaseSelectedList { get; set; }
        //public List<int> referredDideased { get; set; }
        //public List<SpecialDisease> specialDiseaseList { get; set; }
    }
}
