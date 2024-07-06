using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.PopulerLocationHandlers
{
    public class UpdatePopulerLocationCommandHandler : IRequestHandler<UpdatePopulerLocationCommand>
    {
        private readonly IPopulerLocationRepository _repository;
        private readonly IMapper _mapper;

        public UpdatePopulerLocationCommandHandler(IPopulerLocationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(UpdatePopulerLocationCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(_mapper.Map<PopulerLocation>(request));
        }
    }
}
