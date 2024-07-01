using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.AboutDetailHandlers
{
    public class GetAboutDetailQueryHandler : IRequestHandler<GetAboutDetailQuery, List<GetAboutDetailQueryResult>>
    {
        private readonly IMapper _mapper;
        private readonly IAboutDetailRepository _repository;

        public GetAboutDetailQueryHandler(IMapper mapper, IAboutDetailRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<GetAboutDetailQueryResult>> Handle(GetAboutDetailQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetAboutDetailQueryResult>>(await _repository.GetListAsync());
        }
    }
}
