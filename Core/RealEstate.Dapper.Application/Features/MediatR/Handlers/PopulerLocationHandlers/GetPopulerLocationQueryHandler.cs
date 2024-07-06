using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.PopulerLocationHandlers
{
    public class GetPopulerLocationQueryHandler : IRequestHandler<GetPopulerLocationQuery, List<GetPopulerLocationQueryResult>>
    {
        private readonly IPopulerLocationRepository _repository;
        private readonly IMapper _mapper;

        public GetPopulerLocationQueryHandler(IPopulerLocationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetPopulerLocationQueryResult>> Handle(GetPopulerLocationQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetPopulerLocationQueryResult>>(await _repository.GetListAsync());
        }
    }
}
