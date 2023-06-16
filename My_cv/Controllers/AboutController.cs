using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Grpc.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace My_cv.Controllers
{
    public class AboutController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AboutController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
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
            ViewBag.Value1 = "Hakkımda";
            ViewBag.Value2 = "Hakkımda";
            ViewBag.Value3 = "Bilgiler";
            aboutManager.TUpdate(about);
            return View(about);
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile ImageUrl , int AboutID)
        {
            try
            {
                if (ImageUrl != null && ImageUrl.Length > 0)
                {
                    string klasorYolu = Path.Combine(_hostingEnvironment.WebRootPath, "userımage", @"C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\wwwroot\Template\images\userımage");
                    string dosyaAdi = Path.GetFileName(ImageUrl.FileName);
                    string hedefYol = Path.Combine(klasorYolu, dosyaAdi);    
                    using (var fileStream = new FileStream(hedefYol, FileMode.Create))
                    {
                        ImageUrl.CopyTo(fileStream);
                        ViewBag.dosyaAdi = dosyaAdi;
                    }   
                About myAbout = aboutManager.TGetByID(AboutID);
                myAbout.ImageUrl= dosyaAdi;
                aboutManager.TUpdate(myAbout);
                }        
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Index");
        }
    }
}
