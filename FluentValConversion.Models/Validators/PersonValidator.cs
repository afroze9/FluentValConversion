using FluentValConversion.Models;
using FluentValidation;

namespace FluentValConversion.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.ID).NotNull().WithMessage("ID is required");
            RuleFor(x => x.FirstName).NotEmpty().MaximumLength(10).WithMessage("10 length first name");
            RuleFor(x => x.Email).NotNull().EmailAddress().WithMessage("Please enter email");
        }
    }
}
