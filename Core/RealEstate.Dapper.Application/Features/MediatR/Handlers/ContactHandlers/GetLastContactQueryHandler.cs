using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ContactHandlers
{
    public class GetLastContactQueryHandler : IRequestHandler<GetLastContactQuery, List<GetContactQueryResult>>
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;

        public GetLastContactQueryHandler(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public async Task<List<GetContactQueryResult>> Handle(GetLastContactQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetContactQueryResult>>(await _contactRepository.GetListLastContactAsync(request.HowContactCount));
        }
    }
}
