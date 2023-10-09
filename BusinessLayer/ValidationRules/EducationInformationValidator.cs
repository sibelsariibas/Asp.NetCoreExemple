using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using EntityLayer.Concreate;

namespace BusinessLayer.ValidationRules
{
   public class EducationInformationValidator : AbstractValidator<EducationInformation>
    {
        public EducationInformationValidator()
        {
            RuleFor(x => x.SchoolName).NotEmpty().WithMessage("Okul adı boş geçilemez");
            RuleFor(x => x.Branch).NotEmpty().WithMessage("Branş bilgisi boş geçilemez");
        }
    }
}
