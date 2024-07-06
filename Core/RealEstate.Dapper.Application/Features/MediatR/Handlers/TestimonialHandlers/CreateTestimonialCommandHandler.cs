using AutoMapper;
using MediatR;
using RealEstate.Dapper.Application.Features.MediatR.Commands;
using RealEstate.Dapper.Application.Interface;
using RealEstate.Dapper.Domain.Entities;

namespace RealEstate.Dapper.Application.Features.MediatR.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
    {
        private readonly ITestimonialRepository _testimonialRepository;
        private readonly IMapper _mapper;

        public CreateTestimonialCommandHandler(ITestimonialRepository testimonialRepository, IMapper mapper)
        {
            _testimonialRepository = testimonialRepository;
            _mapper = mapper;
        }
        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            await _testimonialRepository.CreateAsync(_mapper.Map<Testimonial>(request));
        }
    }
}
