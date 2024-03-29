﻿using ClubManagement.Application.Common.Utility;
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
            //var allCurrectionalProgramMasters = _context.CurrectionalProgramMaster.GroupBy(u => u.Code).Select(p=>p.).ToList();
           

       

            return View();
        }
        public IActionResult CreateMaster(int ExaminationId)
        {
            try
            {
                var packageId = _context.Examinations.Where(u => u.Id == ExaminationId).Select(u => u.PackageId).FirstOrDefault();
                var SessionGroupId = _context.Packages.Where(u => u.Id == packageId).Select(u => u.Id).FirstOrDefault();
                var SessionCount = _context.SessionGroups.Where(u => u.Id == SessionGroupId).Select(u => u.Count).FirstOrDefault();
                var sessionList = _context.Sessions.Where(u => u.SessionGroupId == SessionGroupId).ToList();
                var correctionalProgramMasterCode = Guid.NewGuid().ToString();
                CorrectionalProgramMasterVM vm = new CorrectionalProgramMasterVM
                {
                    currectionalProgramMasterList = new List<CurrectionalProgramMaster>()
                };
                for (int i = 0; i < SessionCount; i++)
                {
                    var obj = new CurrectionalProgramMaster
                    {
                        Code= correctionalProgramMasterCode,
                        CreateDate = DateTime.Now,
                        SessionId = sessionList[i].Id,
                        Session = sessionList[i],
                        ExaminationId = ExaminationId,
                    };
                    _context.CurrectionalProgramMaster.Add(obj);
                    _context.SaveChanges();
                    vm.currectionalProgramMasterList.Add(obj);
                }
                return View(vm);
            }
            catch (Exception ex)
            {
                TempData["error"] = "خطای سرور";
                Console.WriteLine(ex);
                return RedirectToAction("Index", "CorrectionalProgram");
            }
        }

        public IActionResult CreateDetail(int masterId)
        {
            try
            {
                var master = _context.CurrectionalProgramMaster.Where(u => u.Id == masterId).FirstOrDefault();
                var ExaminationAnomaliesIds = _context.ExaminationAnomalies.Where(u => u.ExaminationId == master.ExaminationId).Select(u => u.AnomalieId).ToList();

                var allAnomalies = _context.ExaminationAnomalies.ToList();
                CorrectionalProgramDetailVM vm = new CorrectionalProgramDetailVM()
                {
                    CurrectionalProgramMasters = _context.CurrectionalProgramMaster.ToList(),
                    CorrectiveActions = _context.CorrectiveActions.ToList(),
                    ExaminationAnomalies = new List<Anomalie>(),
                    //ExaminationId = _context.Examinations.Where(u => u.Id == master.ExaminationId).Select(u=>u.Id).FirstOrDefault(),
                    masterId = masterId,
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
            catch (Exception ex)
            {
                TempData["error"] = "خطای سرور";
                Console.WriteLine(ex);
                return RedirectToAction("Index", "CorrectionalProgramController");
            } 
        }


        [HttpPost]
        public IActionResult CreateDetail(CorrectionalProgramDetailVM vm)
        {


            try
            {
                if (ModelState.IsValid)
                {

                    CurrectionalProgramDetail currectionalProgramDetailForSave = vm.CurrectionalProgramDetail;
                    currectionalProgramDetailForSave.CreateDate = DateTime.Now;
                    currectionalProgramDetailForSave.CurrectionalProgramMasterId = vm.masterId;
                    _context.CurrectionalProgramDetail.Add(currectionalProgramDetailForSave);

                    _context.SaveChanges();
                    TempData["success"] = "ثبت با موفقیت انجام شد";
                    return RedirectToAction("CreateDetail", "CorrectionalProgram",new { masterId = vm.masterId});
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
