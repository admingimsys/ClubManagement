using ClubManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace ClubManagement.Web.ViewModels
{
    public class ExaminationVM
    {
        public Examination Examinations { get; set; }
        [ValidateNever]
        public IFormFile AttachFile { get; set; }

        [ValidateNever]

        public List<BodyType> BodyTypes { get; set; }
        [ValidateNever]

        public List<User> Users { get; set; }
        [ValidateNever]

        public List<Branch> Branches { get; set; }
        [ValidateNever]

        public List<Anomalie> Anomalies { get; set; }
        [ValidateNever]

        public List<Referred> Referreds { get; set; }
        [ValidateNever]

        public List<Package> Packages { get; set; }
        public string? AnomaliesSelected { get; set; }
        public string? PackageIdSelected { get; set; }

        public string? Height { get; set; } = "0";
        public string? Weight { get; set; }="0";

    }
}
