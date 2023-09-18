using AutoMapper;
using TaskWebApi.Features.TaskTypes.Requests.Commands;
using TaskWebApi.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace TaskWebApi.Features.TaskDatas.Handlers.Commands
{
    public class DeleteTaskDataCommandHandler : IRequestHandler<DeleteTaskDataCommand, Unit>
    {
        private readonly ITaskDataRepository _TaskDataRepository;
        private readonly IMapper _mapper;

        public DeleteTaskDataCommandHandler(ITaskDataRepository TaskDataRepository,IMapper mapper)
        {
            _TaskDataRepository = TaskDataRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteTaskDataCommand request, CancellationToken cancellationToken)
        {
            var TaskData = await _TaskDataRepository.Get(request.Id);

            if (TaskData == null)
                throw new NotFoundException(nameof(TaskData),request.Id);

            await _TaskDataRepository.Delete(TaskData);

            return Unit.Value;
        }
    }
}
