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
    public class ServicesController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Value1 = "Mesleki Kazanımlar";
            ViewBag.Value2 = "Mesleki Kazanımlar";
            ViewBag.Value3 = "Mesleki Kazanımlar";
            var values = serviceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.Value1 = "Mesleki Kazanımlar";
            ViewBag.Value2 = "Mesleki Kazanımlar";
            ViewBag.Value3 = "Mesleki Kazanımlar";
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int Id)
        {
            Service service = serviceManager.TGetByID(Id);
            serviceManager.TDelete(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int Id)
        {
            Service service = serviceManager.TGetByID(Id);
            ViewBag.Value1 = "Mesleki Kazanımlar";
            ViewBag.Value2 = "Mesleki Kazanımlar";
            ViewBag.Value3 = "Mesleki Kazanımlar";
            return View(service);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
