using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.AboutServiceHandlers
{
    public class CreateAboutServiceCommandHandler : IRequestHandler<CreateAboutServiceCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAboutServiceRepository _aboutServiceRepository;

        public CreateAboutServiceCommandHandler(IMapper mapper, IAboutServiceRepository aboutServiceRepository)
        {
            _mapper = mapper;
            _aboutServiceRepository = aboutServiceRepository;
        }

        public async Task Handle(CreateAboutServiceCommand request, CancellationToken cancellationToken)
        {
            await _aboutServiceRepository.CreateAsync(_mapper.Map<AboutService>(request));
        }
    }
}
