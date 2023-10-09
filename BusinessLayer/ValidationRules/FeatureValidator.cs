using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using EntityLayer.Concreate;

namespace BusinessLayer.ValidationRules
{
    class FeatureValidator : AbstractValidator<Feature>
    {
        public FeatureValidator()
        {

        }
    }
}
