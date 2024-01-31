using ClubManagement.Domain.Entities;

namespace ClubManagement.Web.ViewModels
{
    public class ExaminationIndexVM
    {
        public  List<Examination> Examinations { get; set; }
        public List<Branch> Branchs { get; set; }
        public List<User> Users { get; set; }
    }
}
