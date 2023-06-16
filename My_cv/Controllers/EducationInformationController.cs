using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;

namespace My_cv.Controllers
{
    public class EducationInformationController : Controller
    {
        EducationInformationManager educationInformationManager = new EducationInformationManager(new EfEducationInformationDal());
        public IActionResult Index()
        {
            ViewBag.Value1 = "Eğitim";
            ViewBag.Value2 = "Eğitim";
            ViewBag.Value3 = "Eğitim Bilgisi";
            var response = educationInformationManager.TGetList();
            return View(response);
        }

        public IActionResult DeleteEducationInformation(int Id)
        {
            var education = educationInformationManager.TGetByID(Id);
            educationInformationManager.TDelete(education);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateEducationInformation(int Id)
        {
            ViewBag.Value1 = "Eğitim";
            ViewBag.Value2 = "Eğitim";
            ViewBag.Value3 = " Bilgileri Düzenle";
            var response = educationInformationManager.TGetByID(Id);
            return View(response);
        }

        [HttpPost]
        public IActionResult UpdateEducationInformation(EducationInformation educationInformation)
        {
            educationInformationManager.TUpdate(educationInformation);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddEducationInformation()
        {
            ViewBag.Value1 = "Eğitim";
            ViewBag.Value2 = "Eğitim";
            ViewBag.Value3 = "Eğitim Bilgisi Ekle";
            return View();
        }

        [HttpPost]
        public IActionResult AddEducationInformation(EducationInformation educationInformation)
        {
            educationInformationManager.TAdd(educationInformation);
            return RedirectToAction("Index");
        }
    }
}
