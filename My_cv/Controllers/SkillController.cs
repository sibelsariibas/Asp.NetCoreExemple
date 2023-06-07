using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_cv.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public IActionResult Index()
        {
            ViewBag.Value1 = "Yetenek";
            ViewBag.Value2 = "Yetenek";
            ViewBag.Value3 = "Yetenek Listesi";
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.Value1 = "Yetenek";
            ViewBag.Value2 = "Yetenek";
            ViewBag.Value3 = "Yetenek Ekle";
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int Id)
        {
            Skill skill = skillManager.TGetByID(Id);
            skillManager.TDelete(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int Id)
        {
            Skill skill = skillManager.TGetByID(Id);
            ViewBag.Value1 = "Yetenek";
            ViewBag.Value2 = "Yetenek";
            ViewBag.Value3 = "Yetenek Bilgileri";
            return View(skill);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
