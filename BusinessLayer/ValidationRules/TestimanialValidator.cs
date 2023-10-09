using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using EntityLayer.Concreate;

namespace BusinessLayer.ValidationRules
{
    public class TestimanialValidator : AbstractValidator<Testimonial>
    {
        public TestimanialValidator()
        {
            RuleFor(x => x.ClientName).NotEmpty().WithMessage("Ad soyad boş geçilemez");
            RuleFor(x => x.Company).NotEmpty().WithMessage("Firma bilgisi boş geçilemez");
        }
    }
}
