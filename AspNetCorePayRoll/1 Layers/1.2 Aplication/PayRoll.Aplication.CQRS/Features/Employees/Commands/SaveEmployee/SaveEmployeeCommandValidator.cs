using FluentValidation;

namespace PayRoll.Aplication.CQRS.Features.Employees.Commands.SaveEmployee
{
    public class SaveEmployeeCommandValidator : AbstractValidator<SaveEmployeeCommand>
    {

        public SaveEmployeeCommandValidator()
        {
            RuleFor(p => p.EmployeeName)
                .NotEmpty().WithMessage("{EmployeeName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{EmployeeName} is required");
        }

    }
}
