using ClubManagement.Domain.Entities;

namespace ClubManagement.Web.ViewModels
{
    public class CorrectionalProgramDetailVM
    {
        public List<CurrectionalProgramMaster>? CurrectionalProgramMasters { get; set; }
        
        public List<CorrectiveAction>? CorrectiveActions { get; set; }
        public List<Anomalie>? ExaminationAnomalies { get; set; }
        public List<Session> Sessions { get; set; }
        public List<Unit> Units { get; set; }

        public CurrectionalProgramDetail CurrectionalProgramDetail { get; set; }
        public int ExaminationId { get; set; }









    }
}
