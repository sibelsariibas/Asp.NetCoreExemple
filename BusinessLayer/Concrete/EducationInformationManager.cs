using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
  public  class EducationInformationManager : IGenericService<EducationInformation>
    {
        IEducationInformationDal _educationInformationDal;


        public EducationInformationManager(IEducationInformationDal educationInformation)
        {
            _educationInformationDal = educationInformation;
        }

        public void TAdd(EducationInformation t)
        {
            _educationInformationDal.Insert(t);
        }

        public void TDelete(EducationInformation t)
        {
            _educationInformationDal.Delete(t);
        }

        public EducationInformation TGetByID(int id)
        {
            return _educationInformationDal.GetByID(id);
        }

        public List<EducationInformation> TGetList()
        {
            return _educationInformationDal.GetList();
        }

        public void TUpdate(EducationInformation t)
        {
            _educationInformationDal.Update(t);
        }
    }
}
