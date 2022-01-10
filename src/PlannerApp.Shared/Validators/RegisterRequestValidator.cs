using FluentValidation;
using PlannerApp.Shared.Models;

namespace PlannerApp.Shared.Validators
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Email is not a valid email address");

            RuleFor(p => p.FirstName)
                .NotEmpty().WithMessage("Firstname is required")
                .MaximumLength(25)
                .WithMessage("Firstname must be less than 25 characters");

            RuleFor(p => p.LastName)
                .NotEmpty().WithMessage("Lastname is required")
                .MaximumLength(25)
                .WithMessage("Lastname must be less than 25 characters");

            RuleFor(p => p.Password)
                .NotEmpty()
                .WithMessage("Password is required")
                .MinimumLength(5)
                .WithMessage("Password mus be at least 5 characters");

            RuleFor(p => p.ConfirmPassword)
                .Equal(p => p.Password)
                .WithMessage("Confirm password is not match with password");
        }
    }
}
