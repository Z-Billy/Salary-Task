using FluentValidation;

namespace TaskWebApi.DTOs.SalaryType.Validators
{
    public class CreateSalaryDataValidator : AbstractValidator<CreateTaskDataDto>
    {
        public CreateSalaryDataValidator()
        {
            Include(new ISalaryDataDtoValidator());
        }
    }
}
