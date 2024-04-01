using FluentValidation;
using Traversal.Core.Concrete;

namespace Traversal.Service.FluentValidation
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen adını giriniz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen 3 karakterden daha uzun isim giriniz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lütfen 30 karakterden daha kısa isim giriniz");

            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen açıklama giriniz");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz");

        }
    
    }
}
