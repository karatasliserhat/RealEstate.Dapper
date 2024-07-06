using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.PopulerLocationHandlers
{
    public class GetPopulerLocationByIdQueryHandler : IRequestHandler<GetPopulerLocationByIdQuery, GetPopulerLocationByIdQueryResult>
    {
        private readonly IPopulerLocationRepository _populerLocationRepository;
        private readonly IMapper _mapper;

        public GetPopulerLocationByIdQueryHandler(IPopulerLocationRepository populerLocationRepository, IMapper mapper)
        {
            _populerLocationRepository = populerLocationRepository;
            _mapper = mapper;
        }

        public async Task<GetPopulerLocationByIdQueryResult> Handle(GetPopulerLocationByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetPopulerLocationByIdQueryResult>(await _populerLocationRepository.GetByIdAsync(request.Id));
        }
    }
}
