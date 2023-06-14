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
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Value1 = "Hakkımda";
            ViewBag.Value2 = "Hakkımda";
            ViewBag.Value3 = "Bilgiler";
            var values = aboutManager.TGetList().FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index");
        }
    }
}
