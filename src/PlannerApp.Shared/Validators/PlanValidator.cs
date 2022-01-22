using FluentValidation;
using PlannerApp.Shared.Models;

namespace PlannerApp.Shared.Validators
{
    public class PlanValidator: AbstractValidator<PlanDetail>
    {
        public PlanValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .WithMessage("Title is required")
                .MaximumLength(80)
                .WithMessage("Title must be less than 80 characters");

            RuleFor(p => p.Description)
                .NotEmpty()
                .WithMessage("Description is required")
                .MaximumLength(500)
                .WithMessage("Title must be less than 500 characters");
        }
    }
}
