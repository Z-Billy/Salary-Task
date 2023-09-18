using AutoMapper;
using TaskWebApi.DTOs.TaskType;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaskWebApi.Features.TaskTypes.Requests.Queries;
using TaskWebApi.Contracts.Persistence;

namespace TaskWebApi.Features.LeaveTypes.Handlers.Queries
{
    public class GetTaskWebApiDetailRequestHandler : IRequestHandler<GetTaskDataDetailRequest, TaskDataDto>
    {
        private readonly ITaskDataRepository _taskDataRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ITaskDataRepository taskWebApiRepository, IMapper mapper)
        {
            _taskDataRepository = taskWebApiRepository;
            _mapper = mapper;
        }
        public async Task<TaskDataDto> Handle(GetTaskDataDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _taskDataRepository.Get(request.NationalCode);
            return _mapper.Map<TaskDataDto>(leaveType);
        }
    }
}
