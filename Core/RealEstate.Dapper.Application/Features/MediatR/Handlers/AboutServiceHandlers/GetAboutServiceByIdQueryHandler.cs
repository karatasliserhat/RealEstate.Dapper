using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.AboutServiceHandlers
{
    public class GetAboutServiceByIdQueryHandler : IRequestHandler<GetAboutServiceByIdQuery, GetAboutServiceByIdQueryResult>
    {
        private readonly IMapper _mapper;
        private readonly IAboutServiceRepository _aboutServiceRepository;

        public GetAboutServiceByIdQueryHandler(IAboutServiceRepository aboutServiceRepository, IMapper mapper)
        {
            _aboutServiceRepository = aboutServiceRepository;
            _mapper = mapper;
        }

        public async Task<GetAboutServiceByIdQueryResult> Handle(GetAboutServiceByIdQuery request, CancellationToken cancellationToken)
        {
            return  _mapper.Map<GetAboutServiceByIdQueryResult>(await _aboutServiceRepository.GetByIdAsync(request.Id));
        }
    }
}
