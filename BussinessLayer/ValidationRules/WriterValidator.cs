using EntityLayer.Concrete;
using FluentValidation;

namespace BussinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş Geçemezsiniz!!!");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soy adını Boş Geçemezsiniz!!!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Ünvanını Boş Geçemezsiniz!!!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını Boş Geçemezsiniz!!!");
            RuleFor(x => x.WriterAbout).MaximumLength(100).WithMessage("Hakkımda kısmına 100 karakterden fazla giriş yapamazsınız!!!");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapınız.");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Fazla Değer Girişi Yapmayın");

        }
    }
}
