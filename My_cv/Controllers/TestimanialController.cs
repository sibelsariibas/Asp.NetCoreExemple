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
    public class TestimanialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal () );
        public IActionResult Index()
        {
            ViewBag.Value1 = "Referans";
            ViewBag.Value2 = "Referans";
            ViewBag.Value3 = "Referans Listesi";
            var list = testimonialManager.TGetList();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddTestimanial()
        {
            ViewBag.Value1 = "Referans";
            ViewBag.Value2 = "Referans";
            ViewBag.Value3 = "Referans Ekle";
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimanial(Testimonial testimonial)
        {
            testimonialManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimanial(int id)
        {
            Testimonial testimonial = testimonialManager.TGetByID(id);
            testimonialManager.TDelete(testimonial);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestimanial(int id)
        {
            ViewBag.Value1 = "Referans";
            ViewBag.Value2 = "Referans";
            ViewBag.Value3 = "Referans Bilgileri";
            Testimonial testimonial = testimonialManager.TGetByID(id);
            return View(testimonial);
        }

        [HttpPost]
        public IActionResult UpdateTestimanial(Testimonial testimonial)
        {
            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
