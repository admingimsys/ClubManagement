﻿using ClubManagement.Application.Common.Utility;
using ClubManagement.Domain.Entities;
using ClubManagement.Infrastructure.Data;
using ClubManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using static System.Net.WebRequestMethods;

namespace ClubManagement.Web.Controllers
{
    public class ReferredController : Controller
    {
        private readonly ClubManagmentContext _context;
        public ReferredController(ClubManagmentContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            try
            {
                var referreds = _context.Referreds.ToList();
                return View(referreds);
            }
            catch (Exception ex)
            {
                TempData["error"] = "خطای سرور";
                Console.WriteLine(ex);
                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult Create()
        {
            try
            {
                ReferredVM vm = new ReferredVM()
                {
                    IntroductionMethods = _context.IntroductionMethods.ToList(),
                    States = _context.States.ToList()
                };
                return View(vm);
            }
            catch (Exception ex)
            {
                TempData["error"] = "خطای سرور";
                Console.WriteLine(ex);
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult Create(ReferredVM vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Referred referredForSave = vm.referred;
                    referredForSave.BirthDate = DateOnly.FromDateTime(Show_Date.converpersianNumber(vm.birthDate));
                    referredForSave.Gender = vm.gender == "1" ? true : false;
                    referredForSave.CreateDate = DateTime.Now;
                    referredForSave.IsMarid = vm.isMaried == "1" ? true : false;
                    referredForSave.Code = Guid.NewGuid().ToString().Substring(20);

                    if (vm.ImageFile != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            vm.ImageFile.CopyTo(ms);
                            referredForSave.Image = ms.ToArray();
                        }
                    }

                    _context.Referreds.Add(referredForSave);
                    _context.SaveChanges();
                    TempData["success"] = "ذخیره اطلاعات با موفقیت انجام شد";
                    return RedirectToAction("Index", "Referred");
                }
                else
                {
                    TempData["error"] = "اطلاعات ورودی صحیح نمیباشد";
                    vm.IntroductionMethods = _context.IntroductionMethods.ToList();
                    vm.States = _context.States.ToList();
                    return View(vm);
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = "خطای سرور";
                Console.WriteLine(ex);
                return RedirectToAction("Index", "Referred");
            }
        }

        public IActionResult Update(int referredid)
        {
            try
            {
                Referred referredForUpdate = _context.Referreds.Where(u => u.Id == referredid).First();
                if (referredForUpdate != null)
                {
                    ReferredVM vm = new ReferredVM()
                    {
                        IntroductionMethods = _context.IntroductionMethods.ToList(),
                        States = _context.States.ToList(),
                        birthDate = referredForUpdate.BirthDate.ToString(),
                        gender = referredForUpdate.Gender == true ? "1" : "0",
                        isMaried = referredForUpdate.IsMarid == true ? "1" : "0",
                        referred = referredForUpdate,
                        //Image

                    };
                    return View(vm);
                }
                TempData["error"] = "مشتری مورد نظر یافت نشد";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                TempData["error"] = "خطای سرور";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult Update(ReferredVM vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Referred referredForUpdate = vm.referred;
                    referredForUpdate.BirthDate = DateOnly.FromDateTime(Show_Date.converpersianNumber(vm.birthDate));
                    referredForUpdate.Gender = vm.gender == "1" ? true : false;
                    referredForUpdate.CreateDate = DateTime.Now;
                    referredForUpdate.IsMarid = vm.isMaried == "1" ? true : false;
                    referredForUpdate.Code = Guid.NewGuid().ToString().Substring(20);
                    referredForUpdate.ModifyDate = DateTime.Now;

                    if (vm.ImageFile != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            vm.ImageFile.CopyTo(ms);
                            referredForUpdate.Image = ms.ToArray();
                        }
                    }

                    _context.Referreds.Update(referredForUpdate);
                    _context.SaveChanges();
                    TempData["error"] = "ویرایش با موفقیت انجام شد";
                    return RedirectToAction("Index", "Referred");
                }
                else
                {
                    TempData["error"] = "اطلاعات ورودی صحیح نمی باشد";
                    vm.IntroductionMethods = _context.IntroductionMethods.ToList();
                    vm.States = _context.States.ToList();
                    return View(vm);
                }
            }
            catch (Exception ex)
            {
                vm.IntroductionMethods = _context.IntroductionMethods.ToList();
                vm.States = _context.States.ToList();
                return View(vm);
            }
        }

        public IActionResult HealthInfo(int referredid)
        {
            try
            {
                var healthInfo = _context.HealthInfos.Where(u => u.ReferredId == referredid).FirstOrDefault();
                HealthInfoVM vm = new HealthInfoVM();
                if (healthInfo != null)
                {
                    //vm.healthInfo = healthInfo;
                    //vm.hadSurgery = healthInfo.HadSurgery==true ? "1":"0";
                    //vm.HasPreviousDiet = healthInfo.HasPreviousDiet == true ? "1" : "0";
                    //vm.HasMetallInBody = healthInfo.HasMetallInBody == true ? "1" : "0";
                    //return View(vm);
                    TempData["error"] = "ویرایش اطلاعات سلامت غیرفعال می باشد";
                    return RedirectToAction("Index");
                }
                else
                {
                    vm.healthInfo = new HealthInfo
                    {
                        ReferredId = referredid
                    };
                    return View(vm);
                }
            }
            catch
            {
                TempData["error"] = "خطای سرور";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult HealthInfo(HealthInfoVM vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    vm.healthInfo.HasMetallInBody = vm.HasMetallInBody == "1" ? true : false;
                    vm.healthInfo.HadSurgery = vm.hadSurgery == "1" ? true : false;
                    vm.healthInfo.HasPreviousDiet = vm.HasPreviousDiet == "1" ? true : false;
                    if (vm.healthInfo.Id == 0)
                    {
                        vm.healthInfo.CreateDate = DateTime.Now;
                        _context.HealthInfos.Add(vm.healthInfo);
                        _context.SaveChanges();
                        TempData["success"] = "ذخیره با موفقیت انجام شد";
                    }
                    else
                    {
                        vm.healthInfo.ModifyDate = DateTime.Now;
                        _context.HealthInfos.Update(vm.healthInfo);
                        _context.SaveChanges();
                        TempData["success"] = "ویرایش با موفقیت انجام شد";
                    }
                    return RedirectToAction("Index");
                }
                else
                {
                    vm.healthInfo.HasMetallInBody = vm.HasMetallInBody == "1" ? true : false;
                    vm.healthInfo.HadSurgery = vm.hadSurgery == "1" ? true : false;
                    vm.healthInfo.HasPreviousDiet = vm.HasPreviousDiet == "1" ? true : false;
                    TempData["error"] = "اطلاعات ورودی صحیح نمی باشد";
                    return View(vm);
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = "خطای سرور";
                Console.WriteLine(ex);
                return RedirectToAction("Index");
            }
        }

        public IActionResult PersonalInfo(int referredid)
        {
            try
            {
                var personalInfo = _context.PersonalInfos.Where(u => u.ReferredId == referredid).FirstOrDefault();
                if (personalInfo != null)
                {
                    return View(personalInfo);
                }
                else
                {
                    personalInfo = new PersonalInfo { ReferredId = referredid };
                    return View(personalInfo);
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = "خطای سرور";
                Console.WriteLine(ex);
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult PersonalInfo(PersonalInfo vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (vm.Id == 0)
                    {
                        vm.CreateDate = DateTime.Now;
                        _context.PersonalInfos.Add(vm);
                        _context.SaveChanges();
                        TempData["success"] = "ذخیره با موفقیت انجام شد";
                    }
                    else
                    {
                        vm.ModifyDate = DateTime.Now;
                        _context.PersonalInfos.Update(vm);
                        _context.SaveChanges();
                        TempData["success"] = "ویرایش با موفقیت انجام شد";
                    }
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["error"] = " اطلاعات ورودی صحیح نمیباشد";
                    return View(vm);
                }
            }
            catch (Exception ex)
            {
                TempData["error"] = "خطای سرور";
                Console.WriteLine(ex);
                return RedirectToAction("Index");
            }
        }

        #region API Call
        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                Referred? referredForRemove = _context.Referreds.Where(u => u.Id == id).FirstOrDefault();
                if (referredForRemove != null)
                {
                    _context.Referreds.Remove(referredForRemove);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                TempData["error"] = "مشتری مورد نظر یافت نشد";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                TempData["error"] = "خطای سرور";
                return RedirectToAction("Index");
            }
        }
        #endregion

    }
}
