using ClubManagement.Domain.Entities;

namespace ClubManagement.Web.ViewModels
{
    public class HealthInfoVM
    {
        public IFormFile File { get; set; }
        public HealthInfo healthInfo { get; set; }
        public string hadSurgery { get; set; }
        public string HasPreviousDiet { get; set; }
        public string HasMetallInBody { get; set; }

    }
}
