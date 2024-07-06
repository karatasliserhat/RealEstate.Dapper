using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StepsGridHandlers
{
    public class UpdateStepsGridCommandHandler : IRequestHandler<UpdateStepsGridCommand>
    {
        private readonly IMapper _mapper;
        private readonly IStepsGridRepository _stepsGridRepository;

        public UpdateStepsGridCommandHandler(IMapper mapper, IStepsGridRepository stepsGridRepository)
        {
            _mapper = mapper;
            _stepsGridRepository = stepsGridRepository;
        }

        public async Task Handle(UpdateStepsGridCommand request, CancellationToken cancellationToken)
        {
            await _stepsGridRepository.UpdateAsync(_mapper.Map<StepsGrid>(request));
        }
    }
}
