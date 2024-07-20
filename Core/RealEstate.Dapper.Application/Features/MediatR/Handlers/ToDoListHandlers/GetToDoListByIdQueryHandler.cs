using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Queries;
using RealEstate.Dapper.Application.Features.MediatR.Results;
using RealEstate.Dapper.Application.Interface;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ToDoListHandlers
{
    public class GetToDoListByIdQueryHandler : IRequestHandler<GetToDoListByIdQuery, GetToDoListByIdQueryResult>
    {
        private readonly IToDoListRepository _repository;
        private readonly IMapper _mapper;

        public GetToDoListByIdQueryHandler(IMapper mapper, IToDoListRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<GetToDoListByIdQueryResult> Handle(GetToDoListByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetToDoListByIdQueryResult>(await _repository.GetByIdAsync(request.Id));
        }
    }
}
