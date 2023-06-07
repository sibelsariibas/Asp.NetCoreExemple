using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ExperienceValidator : AbstractValidator<Experience>
    {
        public ExperienceValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Firma Bilgisi Boş Geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görev Tanımı Boş Geçilemez");
            RuleFor(x=>x.Description).MinimumLength(10).WithMessage("Görev tanımı en az 10 karakter içermelidir.");
        }
    }
}
