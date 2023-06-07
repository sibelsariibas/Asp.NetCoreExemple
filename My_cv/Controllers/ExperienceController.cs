using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_cv.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.Value1 = "Deneyim";
            ViewBag.Value2 = "Deneyim";
            ViewBag.Value3 = "Deneyim Listesi";
            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.Value1 = "Deneyim";
            ViewBag.Value2 = "Deneyim";
            ViewBag.Value3 = "Deneyim Ekle";
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            ExperienceValidator validator = new ExperienceValidator();
            ValidationResult result= validator.Validate(experience);

            if(result.IsValid)
            {
                experienceManager.TAdd(experience);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();

        }

        public IActionResult DeleteExperience(int Id)
        {
            Experience experience = experienceManager.TGetByID(Id);
            experienceManager.TDelete(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int Id)
        {
            ViewBag.Value1 = "Deneyim";
            ViewBag.Value2 = "Deneyim";
            ViewBag.Value3 = "Deneyim Bilgileri";
            Experience experience=  experienceManager.TGetByID(Id);
            return View(experience);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            ViewBag.Value1 = "Deneyim";
            ViewBag.Value2 = "Deneyim";
            ViewBag.Value3 = "Deneyim Bilgileri";
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
