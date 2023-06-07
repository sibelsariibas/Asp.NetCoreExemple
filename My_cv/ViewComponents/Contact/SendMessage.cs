using EntityLayer.Concreate;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.EntityFramework;

namespace My_cv.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        SendMessageManager sendMessageManager = new SendMessageManager( new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }

        //[HttpPost]
        //public IViewComponentResult Invoke( Message p)
        //{
        //    //p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    //p.Status = true;
        //    //sendMessageManager.TAdd(p);
        //    return View();

        //}
    }
}
