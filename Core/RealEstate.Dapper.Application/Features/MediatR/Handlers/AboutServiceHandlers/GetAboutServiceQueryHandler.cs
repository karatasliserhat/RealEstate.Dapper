using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.AboutServiceHandlers
{
    public class GetAboutServiceQueryHandler : IRequestHandler<GetAboutServiceQeury, List<GetAboutServiceQueryResult>>
    {
        private readonly IMapper _mapper;
        private readonly IAboutServiceRepository _aboutServiceRepository;

        public GetAboutServiceQueryHandler(IMapper mapper, IAboutServiceRepository aboutServiceRepository)
        {
            _mapper = mapper;
            _aboutServiceRepository = aboutServiceRepository;
        }

        public async Task<List<GetAboutServiceQueryResult>> Handle(GetAboutServiceQeury request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetAboutServiceQueryResult>>(await _aboutServiceRepository.GetListAsync());
        }
    }
}
