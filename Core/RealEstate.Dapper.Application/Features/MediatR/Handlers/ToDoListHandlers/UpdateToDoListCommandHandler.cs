using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.ToDoListHandlers
{
    public class UpdateToDoListCommandHandler : IRequestHandler<UpdateToDoListCommand>
    {
        private readonly IToDoListRepository _repository;
        private readonly IMapper _mapper;

        public UpdateToDoListCommandHandler(IMapper mapper, IToDoListRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Handle(UpdateToDoListCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(_mapper.Map<ToDoList>(request));
        }
    }
}
