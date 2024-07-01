using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.AboutDetailHandlers
{
    public class GetAboutDetailByIdQueryHandler : IRequestHandler<GetByIdAboutDetailQuery, GetByIdAboutDetailQueryResult>
    {
        private readonly IAboutDetailRepository _aboutDetailRepository;
        private readonly IMapper _mapper;

        public GetAboutDetailByIdQueryHandler(IAboutDetailRepository aboutDetailRepository, IMapper mapper)
        {
            _aboutDetailRepository = aboutDetailRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdAboutDetailQueryResult> Handle(GetByIdAboutDetailQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetByIdAboutDetailQueryResult>(await _aboutDetailRepository.GetByIdAsync(request.Id));
        }
    }
}
