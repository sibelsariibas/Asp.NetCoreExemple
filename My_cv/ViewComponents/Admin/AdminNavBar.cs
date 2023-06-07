using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_cv.ViewComponents.Admin
{
    public class AdminNavBar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.d1 = "Ekleme";
            return View();
        }

    }
}
