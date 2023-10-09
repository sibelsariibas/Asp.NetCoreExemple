using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using EntityLayer.Concreate;
namespace BusinessLayer.ValidationRules
{
    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık bilgisi boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(10).WithMessage("En az 10 karakter içermelidir.");
            RuleFor(x => x.Value).Must(x => int.Parse(x) > 0 && int.Parse(x) <= 100);
        }
    }
}
