using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ToDoListHandlers
{
    public class GetToDoListQueryHandler : IRequestHandler<GetToDoListQuery, List<GetToDoListQueryResult>>
    {
        private readonly IToDoListRepository _repository;
        private readonly IMapper _mapper;

        public GetToDoListQueryHandler(IMapper mapper, IToDoListRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<GetToDoListQueryResult>> Handle(GetToDoListQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetToDoListQueryResult>>(await _repository.GetListAsync());
        }
    }
}
