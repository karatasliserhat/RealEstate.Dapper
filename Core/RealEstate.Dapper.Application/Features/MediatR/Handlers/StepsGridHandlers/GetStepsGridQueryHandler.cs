using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StepsGridHandlers
{
    public class GetStepsGridQueryHandler : IRequestHandler<GetStepsGridQuery, List<GetStepsGridQueryResult>>
    {
        private readonly IMapper _mapper;
        private readonly IStepsGridRepository _stepsGridRepository;

        public GetStepsGridQueryHandler(IStepsGridRepository stepsGridRepository, IMapper mapper)
        {
            _stepsGridRepository = stepsGridRepository;
            _mapper = mapper;
        }

        public async Task<List<GetStepsGridQueryResult>> Handle(GetStepsGridQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetStepsGridQueryResult>>(await _stepsGridRepository.GetListAsync());
        }
    }
}
