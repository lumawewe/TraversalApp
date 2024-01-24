using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Core.Concrete;

namespace Traversal.Service.FluentValidation
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator() 
        { 
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açıklama kısmı minumum 50 karakter olmalıdır");
            RuleFor(x => x.Description).MaximumLength(1000).WithMessage("Açıklama kısmı maxinumum 1000 karakter olmalıdır");

            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz");

        }
    }
}
