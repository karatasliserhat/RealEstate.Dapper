using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.AboutDetailHandlers
{
    public class RemoveAboutDetailCommandHandler : IRequestHandler<RemoveAboutDetailCommand>
    {
        private readonly IAboutDetailRepository _aboutDetailRepository;

        public RemoveAboutDetailCommandHandler(IAboutDetailRepository aboutDetailRepository)
        {
            _aboutDetailRepository = aboutDetailRepository;
        }

        public async Task Handle(RemoveAboutDetailCommand request, CancellationToken cancellationToken)
        {
            await _aboutDetailRepository.DeleteAsync(request.Id);
        }
    }
}
