using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ContactHandlers
{
    public class RemoveContactCommandHandler : IRequestHandler<RemoveContactCommand>
    {
        private readonly IContactRepository _contactRepository;

        public RemoveContactCommandHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task Handle(RemoveContactCommand request, CancellationToken cancellationToken)
        {
            await _contactRepository.DeleteAsync(request.Id);
        }
    }
}
