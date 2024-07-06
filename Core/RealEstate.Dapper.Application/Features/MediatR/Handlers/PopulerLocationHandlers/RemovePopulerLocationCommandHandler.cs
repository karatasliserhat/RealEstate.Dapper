using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.PopulerLocationHandlers
{
    public class RemovePopulerLocationCommandHandler : IRequestHandler<RemovePopulerLocationCommand>
    {
        private readonly IPopulerLocationRepository _repository;

        public RemovePopulerLocationCommandHandler(IPopulerLocationRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemovePopulerLocationCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.Id);
        }
    }
}
