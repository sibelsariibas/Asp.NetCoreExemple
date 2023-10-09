using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ServicesValidator : AbstractValidator<Service>
    {
        public ServicesValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Yetenek bilgisi boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(10).WithMessage("Yetenek bilgisi en az 10 karakter içermelidir.");
        }
    }
}
