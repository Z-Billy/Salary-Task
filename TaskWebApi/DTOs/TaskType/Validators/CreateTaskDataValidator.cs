using FluentValidation;

namespace TaskWebApi.DTOs.TaskType.Validators
{
    public class CreateTaskDataValidator : AbstractValidator<TaskDataDto>
    {
        public CreateTaskDataValidator()
        {
            Include(new ITaskDataDtoValidator());
        }
    }
}
