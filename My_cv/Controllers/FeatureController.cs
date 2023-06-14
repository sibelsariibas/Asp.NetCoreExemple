using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_cv.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Value1 = "Giriş";
            ViewBag.Value2 = "Giriş";
            ViewBag.Value3 = "Bilgiler";
            var values = featureManager.TGetList().FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.Value1 = "Giriş";
            ViewBag.Value2 = "Giriş";
            ViewBag.Value3 = "Bilgiler";
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Feature feature)
        {
            featureManager.TAdd(feature);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int Id)
        {
            Feature feature = featureManager.TGetByID(Id);
            featureManager.TDelete(feature);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int Id)
        {
            Feature feature = featureManager.TGetByID(Id);
            ViewBag.Value1 = "Giriş";
            ViewBag.Value2 = "Giriş";
            ViewBag.Value3 = "Bilgiler";
            return View(feature);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index");
        }
    }
}
