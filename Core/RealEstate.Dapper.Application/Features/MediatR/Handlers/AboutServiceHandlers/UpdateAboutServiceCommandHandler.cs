using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.AboutServiceHandlers
{
    public class UpdateAboutServiceCommandHandler : IRequestHandler<UpdateAboutServiceCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAboutServiceRepository _aboutServiceRepository;

        public UpdateAboutServiceCommandHandler(IAboutServiceRepository aboutServiceRepository, IMapper mapper)
        {
            _aboutServiceRepository = aboutServiceRepository;
            _mapper = mapper;
        }

        public async Task Handle(UpdateAboutServiceCommand request, CancellationToken cancellationToken)
        {
            await _aboutServiceRepository.UpdateAsync(_mapper.Map<AboutService>(request));
        }
    }
}
