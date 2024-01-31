using ClubManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ClubManagement.Web.ViewModels
{
    public class CorrectionalProgramDetailVM
    {
        public List<CurrectionalProgramMaster>? CurrectionalProgramMasters { get; set; }
        
        public List<CorrectiveAction>? CorrectiveActions { get; set; }
        public List<Anomalie>? ExaminationAnomalies { get; set; }
        [ValidateNever]
        public List<Session> Sessions { get; set; }
        [ValidateNever]

        public List<Unit> Units { get; set; }

        public CurrectionalProgramDetail CurrectionalProgramDetail { get; set; }
        public int masterId { get; set; }









    }
}
