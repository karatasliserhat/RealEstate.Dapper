using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StepsGridHandlers
{
    public class CreateStepsGridCommandHandler:IRequestHandler<CreateStepsGridCommand>
    {
        private readonly IMapper _mapper;
        private readonly IStepsGridRepository _stepsGridRepository;

        public CreateStepsGridCommandHandler(IMapper mapper, IStepsGridRepository stepsGridRepository)
        {
            _mapper = mapper;
            _stepsGridRepository = stepsGridRepository;
        }

        public async Task Handle(CreateStepsGridCommand request, CancellationToken cancellationToken)
        {
            await _stepsGridRepository.CreateAsync(_mapper.Map<StepsGrid>(request));
        }
    }
}
