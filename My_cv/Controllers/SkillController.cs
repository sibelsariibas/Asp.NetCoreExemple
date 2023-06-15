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
            ViewBag.Value1 = "Teknik Bilgi";
            ViewBag.Value2 = "Teknik Bilgi";
            ViewBag.Value3 = "Teknik Bilgi Listesi";
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.Value1 = "Teknik Bilgi";
            ViewBag.Value2 = "Teknik Bilgi";
            ViewBag.Value3 = "Teknik Bilgi Ekle";
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
            ViewBag.Value1 = "Teknik Bilgi";
            ViewBag.Value2 = "Teknik Bilgi";
            ViewBag.Value3 = "Teknik Bilgi Kaydı";
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
