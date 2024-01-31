using ClubManagement.Application.Common.Utility;
using ClubManagement.Domain.Entities;
using ClubManagement.Infrastructure.Data;
using ClubManagement.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ClubManagement.Web.Controllers
{
    public class CorrectionalProgramController : Controller
    {
        private readonly ClubManagmentContext _context;

        public CorrectionalProgramController(ClubManagmentContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //view model????
            //var CorrectionalProgram = _context.CorrectionalPrograms.ToList();

            return View(/*CorrectionalProgram*/);
        }

        public IActionResult Create(int examinationId)
        {
            var ExaminationAnomaliesIds = _context.ExaminationAnomalies.Where(u => u.ExaminationId == examinationId).Select(u => u.AnomalieId).ToList();

            var allAnomalies = _context.ExaminationAnomalies.ToList();
            CorrectionalProgramDetailVM vm = new CorrectionalProgramDetailVM()
            {
                CurrectionalProgramMasters = _context.CurrectionalProgramMaster.ToList(),
                CorrectiveActions = _context.CorrectiveActions.ToList(),
                ExaminationAnomalies = new List<Anomalie>(),
                ExaminationId = _context.Examinations.Where(u => u.Id == examinationId).Select(u=>u.Id).FirstOrDefault(),
                Sessions = _context.Sessions.ToList(),
                Units = _context.Units.Where(u => u.IsAction == true).ToList()
            };
            foreach (var item in ExaminationAnomaliesIds)
            {
                var res = _context.Anomalies.Where(u => u.Id == item).FirstOrDefault();
                vm.ExaminationAnomalies.Add(res);
            }

            return View(vm);
        }


        [HttpPost]
        public IActionResult Create(CorrectionalProgramDetailVM vm)
        {


            try
            {
                if (ModelState.IsValid)
                {
                    CurrectionalProgramMaster correctionalProgramMasterForSave = new CurrectionalProgramMaster { 
                    CreateDate= DateTime.Now,
                    ExaminationId =vm.ExaminationId
                    };
                    _context.CurrectionalProgramMaster.Add(correctionalProgramMasterForSave);

                    CurrectionalProgramDetail currectionalProgramDetailForSave = vm.CurrectionalProgramDetail;
                    currectionalProgramDetailForSave.CreateDate = DateTime.Now;
                    currectionalProgramDetailForSave.CurrectionalProgramMasterId = correctionalProgramMasterForSave.Id;
                    _context.CurrectionalProgramDetail.Add(currectionalProgramDetailForSave);

                    _context.SaveChanges();

                    return RedirectToAction("Create", "CorrectionalProgram");
                }
                else
                {

                    //form is not valid
                    //vm.Branchs = _context.Branches.ToList();
                    //vm.CorrectiveActions = _context.CorrectiveActions.ToList();
                    //vm.ExaminationAnomalies = _context.BodyTypes.ToList();
                    //vm.ExaminationAnomalie = _context.BodyTypes.ToList();
                    return View(vm);
                }
            }
            catch (Exception ex)
            {
                // handel exeption
                //vm.Branchs = _context.Branches.ToList();
                //vm.CorrectiveActions = _context.CorrectiveActions.ToList();

                return View(vm);
            }




        }
    }
}
