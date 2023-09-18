using AutoMapper;
using TaskWebApi.DTOs.TaskType.Validators;
using TaskWebApi.Features.TaskTypes.Requests.Commands;
using TaskWebApi.Contracts.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using TaskWebApi.Responses;
using System.Linq;

namespace TaskWebApi.Features.TaskDatas.Handlers.Commands
{
    public class CreateTaskDataCommandHandler : IRequestHandler<CreateTaskDataCommand, BaseCommandResponse>
    {
        private readonly ITaskDataRepository _TaskDataRepository;
        private readonly IMapper _mapper;

        public CreateTaskDataCommandHandler(ITaskDataRepository TaskDataRepository,IMapper mapper)
        {
            _TaskDataRepository = TaskDataRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateTaskDataCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            #region Validators

            var validator = new CreateTaskDataValidator();
            var validationResult = await validator.ValidateAsync(request.TaskDataDto);

            #endregion

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }

            else
            {
                var TaskData = _mapper.Map<TaskData>(request.TaskDataDto);
                TaskData = await _TaskDataRepository.Add(TaskData);

                response.Success = true;
                response.Message = "Creation Succesful";
                response.Id = TaskData.Id;
            }

            return response;

        }
    }
}
