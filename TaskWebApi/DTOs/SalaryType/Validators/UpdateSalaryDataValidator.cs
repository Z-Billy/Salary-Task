using FluentValidation;

namespace TaskWebApi.DTOs.SalaryType.Validators
{
    public class UpdateSalaryDataValidator : AbstractValidator<SalaryDataDto>
    {
        public UpdateSalaryDataValidator()
        {
            Include(new ISalaryDataDtoValidator());

            RuleFor(p => p.NationalCode )
                .NotNull().WithMessage("{PropertyName} اجباری است.");
        }
    }
}
