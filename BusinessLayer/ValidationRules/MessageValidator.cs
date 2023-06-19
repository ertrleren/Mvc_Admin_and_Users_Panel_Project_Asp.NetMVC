using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail)
                .NotEmpty().WithMessage("Mail adresini boş geçiremezsin.");
            RuleFor(x => x.Subject)
                .NotEmpty().WithMessage("Konuyu boş geçemezsiniz.");
            RuleFor(x => x.MessageContent)
                .NotEmpty().WithMessage("Mesajı boş geçiremezsin.");
            RuleFor(x => x.Subject)
                .NotEmpty().WithMessage("Konuyu boş geçemezsiniz.");
            RuleFor(x => x.SenderMail)
                .NotEmpty().WithMessage("Gönderen e-posta adresi boş olamaz.")
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");
            RuleFor(x => x.ReceiverMail)
                .NotEmpty().WithMessage("Alıcı e-posta adresi boş olamaz.")
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");
            RuleFor(x => x.Subject)
                .MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz.");
            RuleFor(x => x.Subject)
                .MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla karakter girmeyiniz.");
        }
    }
}
