using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.StepsGridHandlers
{
    public class GetStepsGridByIdQueryHandler : IRequestHandler<GetStepsGridByIdQuery, GetStepsGridByIdQueryResult>
    {
        private readonly IMapper _mapper;
        private readonly IStepsGridRepository _gridRepository;

        public GetStepsGridByIdQueryHandler(IStepsGridRepository gridRepository, IMapper mapper)
        {
            _gridRepository = gridRepository;
            _mapper = mapper;
        }

        public async Task<GetStepsGridByIdQueryResult> Handle(GetStepsGridByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetStepsGridByIdQueryResult>(await _gridRepository.GetByIdAsync(request.Id));
        }
    }
}
