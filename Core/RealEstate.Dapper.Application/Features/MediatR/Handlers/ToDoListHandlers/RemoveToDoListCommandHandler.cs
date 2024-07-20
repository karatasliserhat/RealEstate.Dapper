using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ToDoListHandlers
{
    public class RemoveToDoListCommandHandler : IRequestHandler<RemoveToDoListCommand>
    {
        private readonly IToDoListRepository _repository;

        public RemoveToDoListCommandHandler(IToDoListRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveToDoListCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
