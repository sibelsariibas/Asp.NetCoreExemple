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
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Value1 = "İletişim";
            ViewBag.Value2 = "İletişim";
            ViewBag.Value3 = "İletişim Bilgileri";
            var response = contactManager.TGetList().First();
            return View(response);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            ViewBag.Value1 = "İletişim";
            ViewBag.Value2 = "İletişim";
            ViewBag.Value3 = "İletişim Bilgileri";
            contactManager.TUpdate(contact);
            return View(contact);
        }
    }
}
