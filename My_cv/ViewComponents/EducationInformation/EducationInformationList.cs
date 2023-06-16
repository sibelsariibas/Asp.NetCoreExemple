using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_cv.ViewComponents.EducationInformation
{
    public class EducationInformationList : ViewComponent
    {
        EducationInformationManager educationInformationManager = new EducationInformationManager(new EfEducationInformationDal());
        public IViewComponentResult Invoke()
        {
            var values = educationInformationManager.TGetList();
            return View(values);
        }
    }
}
