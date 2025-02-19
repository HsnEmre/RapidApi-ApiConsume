using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.Validation_Rules.GuestValidationRules
{
    public class UpdateGuestValidator:AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı Boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("isim alanı 3 karakterden kısa olamaz");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("isim alanı 20 karakterden uzun olamaz");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("soyisim alanı 20 karakterden fazla olamaz");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("soyisim alanı 3 karakterden kısa olamaz");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("şehir alanı 20 karakterden fazla olamaz");
        }
    }
}
