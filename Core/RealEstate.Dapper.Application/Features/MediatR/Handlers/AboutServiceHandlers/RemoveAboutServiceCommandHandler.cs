using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.AboutServiceHandlers
{
    public class RemoveAboutServiceCommandHandler : IRequestHandler<RemoveAboutServiceCommand>
    {
        private readonly IAboutServiceRepository _aboutServiceRepository;

        public RemoveAboutServiceCommandHandler(IAboutServiceRepository aboutServiceRepository)
        {
            _aboutServiceRepository = aboutServiceRepository;
        }

        public async Task Handle(RemoveAboutServiceCommand request, CancellationToken cancellationToken)
        {
            await _aboutServiceRepository.DeleteAsync(request.Id);
        }
    }
}
