using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StepsGridHandlers
{
    public class RemoveStepsGridCommandHandler : IRequestHandler<RemoveStepsGridCommand>
    {
        private readonly IStepsGridRepository _stepsGridRepository;

        public RemoveStepsGridCommandHandler(IStepsGridRepository stepsGridRepository)
        {
            _stepsGridRepository = stepsGridRepository;
        }

        public async Task Handle(RemoveStepsGridCommand request, CancellationToken cancellationToken)
        {
            await _stepsGridRepository.DeleteAsync(request.Id);
        }
    }
}
