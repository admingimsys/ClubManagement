using ClubManagement.Domain.Entities;
namespace ClubManagement.Web.ViewModels
{
    public class ExaminationVM
    {
        public Examination Examinations { get; set; }
        public IFormFile AttachFile { get; set; }
    
        public List<BodyType> BodyTypes { get; set; }
        public List<User> Users { get; set; }
        public List<Branch> Branches { get; set; }
        public List<Anomalie> Anomalies { get; set; }
        public List<Referred> Referreds { get; set; }
        public string? AnomaliesSelected { get; set; }

        public string Height { get; set; }
        public string Weight { get; set; }

    }
}
