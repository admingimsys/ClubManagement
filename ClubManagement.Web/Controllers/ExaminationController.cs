using ClubManagement.Domain.Entities;
using ClubManagement.Infrastructure.Data;
using ClubManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ClubManagement.Web.Controllers
{
    public class ExaminationController : Controller
    {
        private readonly ClubManagmentContext _context;
        public ExaminationController(ClubManagmentContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Examination> Examinations = _context.Examinations.Include("Referred").Include("User").Include("Package").Include("Branch").ToList();
          
            return View(Examinations);
        }
        public IActionResult Create()
        {
            try
            {
                ExaminationVM vm = new ExaminationVM
                {
                    Anomalies = _context.Anomalies.ToList(),
                    Users = _context.Users.ToList(),
                    BodyTypes = _context.BodyTypes.ToList(),
                    Referreds = _context.Referreds.ToList(),
                    Branches = _context.Branches.ToList(),
                    Packages = _context.Packages.ToList(),
                };
                return View(vm);
            }
            catch
            {
                return RedirectToAction("Index", "Examination");

            }

        }
        [HttpPost]
        public IActionResult Create(ExaminationVM vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Examination examinationForSave = vm.Examinations;
                    examinationForSave.Height = decimal.Parse(vm.Height);
                    examinationForSave.Weight = decimal.Parse(vm.Weight);
                    examinationForSave.CreateDate = DateTime.Now;
                    examinationForSave.Date = DateOnly.FromDateTime(DateTime.Now);
                    examinationForSave.Hour = TimeOnly.FromDateTime(DateTime.Now);
                    if (vm.AttachFile != null)
                    {
                        //save File 
                    }
                    _context.Examinations.Add(examinationForSave);

                    _context.SaveChanges();
                    if (!string.IsNullOrEmpty(vm.AnomaliesSelected))
                    {
                        List<string> anomaliesSelectedList = vm.AnomaliesSelected.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
                        foreach (var anomaliesSelected in anomaliesSelectedList)
                        {
                            ExaminationAnomalie examinationAnomalieForSave = new ExaminationAnomalie
                            {
                                CreateDate = DateTime.Now,
                                AnomalieId = int.Parse(anomaliesSelected),
                                ExaminationId = examinationForSave.Id,
                            };
                            _context.ExaminationAnomalies.Add(examinationAnomalieForSave);

                        }
                        _context.SaveChanges();
                    }



                    return RedirectToAction("Index", "CorrectionalProgram", new { ExaminationId = examinationForSave.Id });

                }
                //not valid

                return null;
            }
            catch (Exception ex)
            {
                vm.Anomalies = _context.Anomalies.ToList();
                vm.Users = _context.Users.ToList();
                vm.BodyTypes = _context.BodyTypes.ToList();
                vm.Referreds = _context.Referreds.ToList();
                vm.Packages = _context.Packages.ToList();

                return View(vm);
            }


        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

    }
}
