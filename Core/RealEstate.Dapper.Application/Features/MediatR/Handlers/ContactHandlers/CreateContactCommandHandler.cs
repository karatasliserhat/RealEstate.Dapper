using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand>
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;

        public CreateContactCommandHandler(IMapper mapper, IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            await _contactRepository.CreateAsync(_mapper.Map<Contact>(request));
        }
    }
}
