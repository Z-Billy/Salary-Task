using AutoMapper;
using TaskWebApi.DTOs.TaskType.Validators;
using TaskWebApi.Features.TaskTypes.Requests.Commands;
using TaskWebApi.Contracts.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskWebApi.Features.TaskDatas.Handlers.Commands
{
    public class UpdateTaskDataCommandHandler : IRequestHandler<UpdateTaskDataCommand, Unit>
    {
        private readonly ITaskDataRepository _TaskDataRepository;
        private readonly IMapper _mapper;
        public UpdateTaskDataCommandHandler(ITaskDataRepository TaskDataRepository, IMapper mapper)
        {
            _TaskDataRepository = TaskDataRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateTaskDataCommand request, CancellationToken cancellationToken)
        {
            #region Validators
            var validator = new UpdateTaskDataValidator();
            var validationResult = await validator.ValidateAsync(request.TaskDataDto);

            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);

            #endregion
            var TaskData = await _TaskDataRepository.Get(request.TaskDataDto.Id);
            _mapper.Map(request.TaskDataDto,TaskData);
            await _TaskDataRepository.Update(TaskData);

            return Unit.Value;
        }
    }
}
