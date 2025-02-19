using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.Validation_Rules.GuestValidationRules
{
    public class GuestCreateValidator : AbstractValidator<CreateGuestDto>
    {
        public GuestCreateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("soyisim alanı boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("şehir alanı boş geçilemez");




        }
    }
}
