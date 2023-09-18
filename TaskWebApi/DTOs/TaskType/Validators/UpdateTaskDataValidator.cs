using FluentValidation;

namespace TaskWebApi.DTOs.TaskType.Validators
{
    public class UpdateTaskDataValidator : AbstractValidator<TaskDataDto>
    {
        public UpdateTaskDataValidator()
        {
            Include(new ITaskDataDtoValidator());

            RuleFor(p => p.GetFirstName())
                .NotNull().WithMessage("{PropertyName} اجباری است.");
        }
    }
}
