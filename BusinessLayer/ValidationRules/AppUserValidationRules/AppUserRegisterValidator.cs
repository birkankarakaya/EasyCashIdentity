using DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-mail alanı boş geçilemez!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez!");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz!");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz!");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Şifreler aynı değil!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz!");
        }
    }
}
