using FluentValidation;

namespace PayRoll.Aplication.CQRS.Features.Employees.Commands.Update
{
    public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        public UpdateEmployeeCommandValidator()
        {
            RuleFor(p => p.EmployeeName)
                .NotEmpty().WithMessage("{EmployeeName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{EmployeeName} is required");
        }
    }
}
