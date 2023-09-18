using AutoMapper;
using TaskWebApi.DTOs.TaskType;
using TaskWebApi.Features.TaskTypes.Requests.Queries;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TaskWebApi.Contracts.Persistence;

namespace TaskWebApi.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetTaskDataListRequest, List<TaskDataDto>>
    {
        private readonly ITaskDataRepository _TaskDataRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeListRequestHandler(ITaskDataRepository leaveTypeRepository, IMapper mapper)
        {
            _TaskDataRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<TaskDataDto>> Handle(GetTaskDataListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypeList = await _TaskDataRepository.GetAll();
            return _mapper.Map<List<TaskDataDto>>(leaveTypeList);
        }
    }
}
