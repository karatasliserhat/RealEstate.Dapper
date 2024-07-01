using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.AboutDetailHandlers
{
    public class UpdateAboutDetailCommandHandler : IRequestHandler<UpdateAboutDetailCommand>
    {
        private readonly IAboutDetailRepository _aboutDetailRepository;
        private readonly IMapper _mapper;

        public UpdateAboutDetailCommandHandler(IAboutDetailRepository aboutDetailRepository, IMapper mapper)
        {
            _aboutDetailRepository = aboutDetailRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateAboutDetailCommand request, CancellationToken cancellationToken)
        {
            await _aboutDetailRepository.UpdateAsync(_mapper.Map<AboutDetail>(request));
        }
    }
}
