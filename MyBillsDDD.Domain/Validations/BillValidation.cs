using FluentValidation;
using MyBillsDDD.Domain.Entities;

namespace MyBillsDDD.Domain.Validations
{
    public class BillValidation : AbstractValidator<Bill>
    {
        public BillValidation()
        {
            RuleFor(b => b.Name)
                .NotEmpty().WithMessage("Insert a name");

            RuleFor(b => b.PayDay)
               .NotEmpty().WithMessage("Insert a date of payment");
        }
    }
}
